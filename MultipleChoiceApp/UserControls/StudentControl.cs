using FluentValidation.Results;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Bi.Student;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using MultipleChoiceApp.ModelHelpers;

namespace MultipleChoiceApp.UserControls
{
    public partial class StudentControl : UserControl, IPagination
    {
        String controlName = "Students";
        StudentServiceSoapClient mainS = new StudentServiceSoapClient();
        Student formItem;
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public StudentControl()
        {
            InitializeComponent();
        }

        private void StudentControl_Load(object sender, EventArgs e)
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
                    txt_fullname.Text = formItem.FullName.ToString();
                    txt_address.Text = formItem.Address.ToString();
                    txt_major.Text = formItem.Major.ToString();
                    datepicker_dob.Text = formItem.DOB.ToString();
                }
            }
        }


        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Student question = getFormItem();
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
            Student item = getFormItem();
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


        // HELPER METHODS
        private bool handleValidation()
        {
            Student item = getFormItem();
            StudentValidator validator = new StudentValidator();
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
        private Student getFormItem()
        {
            // ANSWER LIST
            Student item = new Student()
            {
                Id = formItem != null ? formItem.Id : -1,
                Code = txt_code.Text.ToString(),
                FullName = txt_fullname.Text.ToString(),
                Address = txt_address.Text.ToString(),
                Major = txt_major.Text.ToString(),
                DOB = Convert.ToDateTime(datepicker_dob.Value.ToString()),
            };
            return item;
        }

        private void refreshList()
        {
            List<Student> list = mainS.getAll(pagination.itemsPerPage, pagination.currentPage);
            refreshList(list);
        }

        private void refreshList(List<Student> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Code, item.FullName,
                    item.Address, item.DOB, item.Major
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
            txt_fullname.Text = "";
            txt_address.Text = "";
            txt_major.Text = "";
            datepicker_dob.Text = new DateTime(2000, 1, 1).ToString();
            formItem = null;
        }

        // EXPORT
        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = savefiledialog_excel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<Student> list = mainS.getAllForSelectData();
                List<Dictionary<String, String>> dicList = list.Select(x => StudentHelper.toDictionary(x)).ToList();
                bool result = FormHelper.toExcel(dicList, savefiledialog_excel.FileName, controlName);
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
                    List<Student> list = StudentHelper.genListByDicList(dicList);
                    if (list != null)
                    {
                        // ADD TO DB
                        int affectedRows = mainS.addMany(list);
                        refreshList();
                        MessageBox.Show(string.Format(Msg.IMPORTED, affectedRows));
                        return;
                    }
                }
                else
                {
                    // INVALID
                    MessageBox.Show(Msg.IMPORT_DATA_INVALID);
                    return;
                }
                MessageBox.Show(Msg.IMPORTED_FAILED);
            }
        }

        private bool checkValidImportedDicList(List<Dictionary<String, String>> dicList)
        {
            return dicList != null && dicList.Count > 0 && StudentHelper.idDictionaryKeysValid(dicList[0].Keys.ToArray());
        }
        //

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
                    List<Student> list = mainS.searchByKeyword(txt_search.Text);
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
