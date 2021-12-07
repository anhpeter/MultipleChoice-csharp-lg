﻿using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using FluentValidation.Results;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.UtilForms;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class QuestionControl : UserControl
    {

        QuestionBUS mainBUS = new QuestionBUS();
        SubjectBUS subjectBUS = new SubjectBUS();
        Pagination pagination;

        //
        Question formItem;
        List<Subject> subjectList;

        public QuestionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        // EVENTS
        private void QuestionControl_Load(object sender, EventArgs e)
        {
            drop_level.Visible = false;
            drop_subject.Visible = false;
            LoadDrops();
            refreshList();
        }

        private void drop_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearForm();
            refreshList();
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getSelectedId();
            if (id > 0)
            {
                formItem = mainBUS.getDetailsById(id);
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
            Question question = getFormQuestion();
            if (handleValidation())
            {
                bool result = mainBUS.add(question);
                if (result)
                {
                    FormHelper.notify(Msg.INSERTED);
                    clearForm();
                    refreshList();
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
                bool result = mainBUS.update(question);
                if (result)
                {
                    FormHelper.notify(Msg.UPDATED);
                    refreshList();
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
                bool result = mainBUS.delete(formItem.Id);
                if (result)
                {
                    FormHelper.notify(Msg.DELETED);
                    clearForm();
                    refreshList();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
        {

        }

        private void btn_import_excel_Click(object sender, EventArgs e)
        {

        }


        // HELPER METHODS
        private bool handleValidation()
        {
            Question question = getFormQuestion();
            QuestionValidator validator = new QuestionValidator();
            ValidationResult results = validator.Validate(question);
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
                List<Question> list = mainBUS.getAllBySubjectId(subjectId);
                refreshList(list);
                handlePagination(subjectId);
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
        }

        private void handlePagination(int subjectId)
        {
            int count = mainBUS.countBySubjectId(subjectId);
            if (pagination == null)
            {
                pagination = new Pagination(count, 1, 5, 3);
            }
            else
            {
                pagination.totalItems = count;
                pagination.calculate();
            }
        }

        private void LoadDrops()
        {
            // SUBJECTS
            if (subjectList == null) subjectList = subjectBUS.getAllForSelectData();
            drop_subject.DataSource = subjectList;
            drop_subject.ValueMember = "Id";
            drop_subject.DisplayMember = "Name";
            drop_subject.SelectedIndex = 1;

            // LEVELS
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("easy", "Easy");
            test.Add("normal", "Normal");
            test.Add("hard", "Hard");
            drop_level.DataSource = new BindingSource(test, null);
            drop_level.DisplayMember = "Value";
            drop_level.ValueMember = "Key";

            drop_level.Visible = true;
            drop_subject.Visible = true;
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
                List<Question> list = mainBUS.searchByKeyword(getFormSubjectId(), txt_search.Text);
                refreshList(list);
            }
        }

    }
}
