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
        int totalItems = 0;

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

        private void gv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getSelectedId();
            if (id > 0)
            {
                formItem = mainS.getDetailsById(id);
                onEdit(formItem);
            }
        }
        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = getSelectedId();
            if (id > 0)
            {
                formItem = mainS.getDetailsById(id);
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
            new FrmQuestionForm(this, null, getFormSubjectId()).ShowDialog();
        }

        async private void btn_delete_Click(object sender, EventArgs e)
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
                    if (!String.IsNullOrEmpty(formItem.ImgFilename))
                    {
                        await FileUpload.deleteFile(formItem.ImgFilename);
                    }
                    clearForm();
                    refreshList();
                    FormHelper.notify(Msg.DELETED);
                }
                else
                {
                    FormHelper.showErrorMsg(Msg.DELETE_CONSTRAINT_ERROR);
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


        public void refreshList()
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
            //drop_level.DataSource = new BindingSource(test, null);
            //drop_level.DisplayMember = "Value";
            //drop_level.ValueMember = "Key";
        }

        public void clearForm()
        {
            formItem = null;
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
            totalItems = mainS.countBySubjectId(getFormSubjectId());
            lbl_total_count.Text = totalItems.ToString();
            return totalItems;
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
        }

        private void onEdit(Question item)
        {
            new FrmQuestionForm(this, item, getFormSubjectId()).ShowDialog();
        }

        private void txt_items_per_page_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHelper.txtNumber(sender, e);
        }

        private void txt_items_per_page_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int itemsPerPage = Util.parseToInt(txt_items_per_page.Text.ToString(), pagination.itemsPerPage);
                if (itemsPerPage != pagination.itemsPerPage)
                {
                    if (itemsPerPage > 0 && itemsPerPage <= totalItems)
                    {
                        pagination.itemsPerPage = itemsPerPage;
                        refreshList();
                    }
                    else
                    {
                        FormHelper.showErrorMsg("Items per page must greater than 0 and less than total items");
                        txt_items_per_page.Text = pagination.itemsPerPage.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}

