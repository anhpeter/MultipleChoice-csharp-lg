using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using FluentValidation.Results;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.ModelHelpers;
using MultipleChoiceApp.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class QuestionControl : UserControl, IPagination
    {
        String controlName = "Questions";
        QuestionServiceSoapClient mainS = new QuestionServiceSoapClient();
        SubjectServiceSoapClient subjectS = new SubjectServiceSoapClient();
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        //
        Question formItem;
        List<Subject> subjectList;
        Boolean searchMode = false;

        public QuestionControl()
        {
            InitializeComponent();
        }

        // EVENTS
        private void QuestionControl_Load(object sender, EventArgs e)
        {
            LoadDrops();
            refreshList();
            clearForm();
        }

        private void drop_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearForm();
            pagination.setCurrentPage(1);
            refreshList();
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getSelectedId();
            if (id > 0)
            {
                formItem = mainS.getDetailsById(id);
                lbl_id.Text = "#" + formItem.Id.ToString();
                txt_question.Text = formItem.Content.ToString();
                txt_chapter.Text = formItem.Chapter.ToString();
                txt_ans1.Text = formItem.Answers[0].Content.ToString();
                txt_ans2.Text = formItem.Answers[1].Content.ToString();
                txt_ans3.Text = formItem.Answers[2].Content.ToString();
                txt_ans4.Text = formItem.Answers[3].Content.ToString();

                drop_level.SelectedValue = formItem.Level;
                checkRdoAnsCorrect(formItem.CorrectAnswerNo);
            }
        }

        private void grid_main_SizeChanged(object sender, EventArgs e)
        {
            gv_main.Columns[0].Width = (int)(50);
            gv_main.Columns[1].Width = (int)(gv_main.Width * 0.5);
        }


        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Question item = getFormQuestion();
            item.CreatedBy = Auth.getIntace().manager.Id;
            if (handleValidation())
            {
                bool result = mainS.add(item);
                if (result)
                {
                    clearForm();
                    refreshList();
                    FormHelper.notify(Msg.INSERTED);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (formItem == null)
            {
                FormHelper.showErrorMsg(Msg.CHOOSE_AN_ITEM);
                return;
            }
            //
            Question question = getFormQuestion();
            if (handleValidation())
            {
                bool result = mainS.update(question);
                if (result)
                {
                    refreshList();
                    FormHelper.notify(Msg.UPDATED);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (formItem == null)
            {
                FormHelper.showErrorMsg(Msg.CHOOSE_AN_ITEM);
                return;
            }
            //
            DialogResult dialogResult = FormHelper.showDeleteConfirm();
            if (dialogResult == DialogResult.Yes)
            {
                bool result = mainS.delete(formItem.Id);
                if (result)
                {
                    clearForm();
                    refreshList();
                    FormHelper.notify(Msg.DELETED);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        // EXPORT
        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = savefiledialog_excel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<Question> list = mainS.getAllWithAnswersBySubjectId(getFormSubjectId());
                List<Dictionary<String, String>> dicList = list.Select(x => QuestionHelper.toDictionary(x)).ToList();
                String subject = getFormSubjectText();
                bool result = FormHelper.toExcel(dicList, savefiledialog_excel.FileName, subject);
                if (result)
                {
                    MessageBox.Show(string.Format(Msg.EXPORTED, list.Count));
                }
                else
                {
                    MessageBox.Show(Msg.EXPORTED_FAILED);
                }
            }
        }

        // IMPORT
        private void btn_import_excel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openfiledialog_excel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<Dictionary<String, String>> dicList = FormHelper.readEx(openfiledialog_excel.FileName);
                if (checkValidImportedDicList(dicList))
                {
                    List<Question> list = QuestionHelper.genListByDicList(dicList, getFormSubjectId());
                    if (list != null)
                    {
                        int affectedRows = mainS.addMany(list);
                        refreshList();
                        MessageBox.Show(string.Format(Msg.IMPORTED, affectedRows));
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Msg.IMPORT_DATA_INVALID);
                    return;
                }
                MessageBox.Show(Msg.IMPORTED_FAILED);
            }
        }

        private bool checkValidImportedDicList(List<Dictionary<String, String>> dicList)
        {
            return dicList != null && dicList.Count > 0 && QuestionHelper.idDictionaryKeysValid(dicList[0].Keys.ToArray());
        }

        // HELPER METHODS
        private bool handleValidation()
        {
            Question item = getFormQuestion();
            QuestionValidator validator = new QuestionValidator();
            ValidationResult results = validator.Validate(item);
            if (results.IsValid)
            {
                return true;
            }
            else
            {
                FormHelper.showValidatorError(results.Errors);
            }
            return false;
        }
        private Question getFormQuestion()
        {
            // ANSWER LIST
            List<Answer> answerList = new List<Answer>();
            int questionId = formItem != null ? formItem.Id : -1;
            BunifuTextBox[] ansTxts = { txt_ans1, txt_ans2, txt_ans3, txt_ans4 };
            for (int i = 0; i < ansTxts.Length; i++)
            {
                answerList.Add(new Answer()
                {
                    QuestionId = questionId,
                    No = i + 1,
                    Content = ansTxts[i].Text.ToString(),
                });
            }

            String level = drop_level.SelectedValue.ToString();
            int correctAnsNo = getCorrectAnsNo();
            int chapter = Util.parseToInt(txt_chapter.Text.ToString(), -1);

            Question item = new Question()
            {
                Id = questionId,
                Answers = answerList,
                Content = txt_question.Text.ToString(),
                SubjectId = getFormSubjectId(),
                Level = level,
                CorrectAnswerNo = correctAnsNo,
                Chapter = chapter
            };
            return item;
        }

        private int getFormSubjectId()
        {
            if (drop_subject.SelectedValue != null) return Util.parseToInt(drop_subject.SelectedValue.ToString(), -1);
            return -1;
        }
        private String getFormSubjectText()
        {
            if (drop_subject.SelectedValue != null) return subjectList[drop_subject.SelectedIndex].Name;
            return "";
        }

        private int getCorrectAnsNo()
        {
            BunifuRadioButton radio = pnl_correct_ans_no.Controls.OfType<BunifuRadioButton>()
                .FirstOrDefault(r => r.Checked);

            return Util.parseToInt(radio.Tag.ToString(), 1);
        }

        private void refreshList()
        {
            int subjectId = getFormSubjectId();
            if (subjectId > 0)
            {
                List<Question> list = mainS.getAllBySubjectId(subjectId, pagination.itemsPerPage, pagination.currentPage);
                refreshList(list);
            }
        }

        private void refreshList(List<Question> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Content,
                    item.SubjectCode, item.Chapter, item.Level, item.CreatedAt
                });
            }
            handlePagination();
        }

        private void handlePagination()
        {
            pnl_pagination.Controls.Clear();
            if (!searchMode)
            {
                paginationControl = new PaginationControl(pagination, this);
                pnl_pagination.Controls.Add(paginationControl);
            }
        }

        private void LoadDrops()
        {
            // SUBJECTS
            if (subjectList == null) subjectList = subjectS.getAllForSelectData();
            drop_subject.DataSource = subjectList;
            drop_subject.ValueMember = "Id";
            drop_subject.DisplayMember = "Name";
            drop_subject.SelectedIndex = 0;

            // LEVELS
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("easy", "Easy");
            test.Add("normal", "Normal");
            test.Add("hard", "Hard");
            drop_level.DataSource = new BindingSource(test, null);
            drop_level.DisplayMember = "Value";
            drop_level.ValueMember = "Key";
        }

        private void clearForm()
        {
            lbl_id.Text = "";
            txt_question.Text = "";
            txt_ans1.Text = "";
            txt_ans2.Text = "";
            txt_ans3.Text = "";
            txt_ans4.Text = "";
            txt_chapter.Text = "1";
            drop_level.SelectedIndex = 0;
            checkRdoAnsCorrect(1);
            formItem = null;

        }

        private void checkRdoAnsCorrect(int no)
        {
            BunifuRadioButton[] rdos = { rdo_ans1, rdo_ans2, rdo_ans3, rdo_ans4 };
            for (int i = 0; i < rdos.Length; i++)
            {
                if (i == no - 1) rdos[i].Checked = true;
                else rdos[i].Checked = false;
            }
        }

        private int getSelectedId()
        {
            try
            {
                int id = Util.parseToInt(gv_main.SelectedRows[0].Cells[0].Value.ToString(), -1);
                return id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        async private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (await FormHelper.getIdle(txt_search))
            {
                String keyword = txt_search.Text;
                if (keyword.Trim() != "")
                {
                    searchMode = true;
                    List<Question> list = mainS.searchByKeyword(getFormSubjectId(), txt_search.Text);
                    refreshList(list);
                }
                else
                {
                    searchMode = false;
                    refreshList();
                }
            }
        }

        public int count()
        {
            return mainS.countBySubjectId(getFormSubjectId());
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
        }

        async private void btn_question_image_Click(object sender, EventArgs e)
        {
            FileUpload fileUpload = new FileUpload();
            openFileDialog_question.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFileDialog_question.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog_question.FileName;
                String imgUrl = await fileUpload.upload("Questions", selectedFile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmQuestionForm().ShowDialog();
        }
    }
}

