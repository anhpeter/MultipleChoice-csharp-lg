using FluentValidation.Results;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class SubjectControl : UserControl, IPagination
    {
        String controlName = "Subjects";
        SubjectServiceSoapClient mainS = new SubjectServiceSoapClient();
        Subject formItem;
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;

        public SubjectControl()
        {
            InitializeComponent();
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {
            refreshList();
            clearForm();
        }


        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getSelectedId();
            if (id > -1)
            {
                formItem = mainS.getDetailsById(id);
                if (formItem != null)
                {
                    txt_code.Text = formItem.Code.ToString();
                    txt_name.Text = formItem.Name.ToString();
                    txt_lecturer.Text = formItem.Lecturer.ToString();
                    txt_total_question.Text = formItem.TotalQuestion.ToString();
                    txt_duration.Text = formItem.Duration.ToString();
                }
            }
        }


        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Subject question = getFormItem();
            if (handleValidation())
            {
                bool result = mainS.add(question);
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
            Subject item = getFormItem();
            if (handleValidation())
            {
                bool result = mainS.update(item);
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
                bool result = mainS.delete(formItem.Id);
                if (result)
                {
                    FormHelper.notify(Msg.DELETED);
                    clearForm();
                    refreshList();
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
            //DialogResult dialogResult = savefiledialog_excel.ShowDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    List<Subject> list = mainS.getAllForSelectData();
            //    List<Dictionary<String, String>> dicList = list.Select(x => x.toDictionary()).ToList();
            //    bool result = FormHelper.toExcel(dicList, savefiledialog_excel.FileName, controlName);
            //    if (result)
            //    {
            //        MessageBox.Show(string.Format(Msg.EXPORTED, list.Count));
            //    }
            //    else
            //    {
            //        MessageBox.Show(Msg.EXPORTED_FAILED);
            //    }
            //}
        }

        // IMPORT
        private void btn_import_excel_Click(object sender, EventArgs e)
        {

            //DialogResult dialogResult = openfiledialog_excel.ShowDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    List<Dictionary<String, String>> dicList = FormHelper.readEx(openfiledialog_excel.FileName);
            //    if (checkValidImportedDicList(dicList))
            //    {
            //        List<Subject> list = Subject.genListByDicList(dicList);
            //        if (list != null)
            //        {
            //            // ADD TO DB
            //            int affectedRows = mainS.addMany(list);
            //            refreshList();
            //            MessageBox.Show(string.Format(Msg.IMPORTED, affectedRows));
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        // INVALID
            //        MessageBox.Show(Msg.IMPORT_DATA_INVALID);
            //        return;
            //    }
            //    MessageBox.Show(Msg.IMPORTED_FAILED);
            //}
        }

        private bool checkValidImportedDicList(List<Dictionary<String, String>> dicList)
        {
            return false;
            //return dicList != null && dicList.Count > 0 && Subject.idDictionaryKeysValid(dicList[0].Keys.ToArray());
        }
        //


        // HELPER METHODS
        private bool handleValidation()
        {
            Subject item = getFormItem();
            SubjectValidator validator = new SubjectValidator();
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
        private Subject getFormItem()
        {
            // ANSWER LIST
            Subject item = new Subject()
            {
                Id = formItem != null ? formItem.Id : -1,
                Code = txt_code.Text.ToString(),
                Name = txt_name.Text.ToString(),
                Lecturer = txt_lecturer.Text.ToString(),
                TotalQuestion = Util.parseToInt(txt_total_question.Text.ToString(), -1),
                Duration = Util.parseToInt(txt_duration.Text.ToString(), -1),
            };
            return item;
        }

        private void refreshList()
        {
            List<Subject> list = mainS.getAll(pagination.itemsPerPage, pagination.currentPage);
            refreshList(list);
        }

        private void refreshList(List<Subject> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Code, item.Name,
                    item.Lecturer, item.TotalQuestion, item.Duration
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

        private void clearForm()
        {
            txt_code.Text = "";
            txt_name.Text = "";
            txt_lecturer.Text = "";
            txt_total_question.Text = "";
            txt_duration.Text = "";
            formItem = null;
        }

        private int getSelectedId()
        {
            try
            {
                return Util.parseToInt(gv_main.SelectedRows[0].Cells[0].Value.ToString(), -1);
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
                    List<Subject> list = mainS.searchByKeyword(txt_search.Text);
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
            return mainS.countAll();
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
        }
    }
}
