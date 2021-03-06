using FluentValidation.Results;
using MultipleChoiceApp.Bi.Manager;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.ModelHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class ManagerControl : UserControl, IPagination
    {
        String controlName = "Managers";
        ManagerServiceSoapClient mainS = new ManagerServiceSoapClient();
        Manager formItem;
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public ManagerControl()
        {
            InitializeComponent();
        }
        private void ManagerControl_Load(object sender, EventArgs e)
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
                    datepicker_dob.Text = formItem.DOB.ToString();
                    txt_phone.Text = formItem.PhoneNumber.ToString();
                    txt_position.Text = formItem.Position.ToString();
                }
            }
        }


        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Manager question = getFormItem();
            if (handleValidation())
            {
                bool result = mainS.add(question);
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
            Manager item = getFormItem();
            if (handleValidation())
            {
                bool result = mainS.update(item);
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
                List<Manager> list = mainS.getAllForSelectData();
                List<Dictionary<String, String>> dicList = list.Select(x => ManagerHelper.toDictionary(x)).ToList();
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
                    List<Manager> list = ManagerHelper.genListByDicList(dicList);
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
            return dicList != null && dicList.Count > 0 && ManagerHelper.idDictionaryKeysValid(dicList[0].Keys.ToArray());
        }
        //


        // HELPER METHODS
        private bool handleValidation()
        {
            Manager item = getFormItem();
            ManagerValidator validator = new ManagerValidator();
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
        private Manager getFormItem()
        {
            // ANSWER LIST
            Manager item = new Manager()
            {
                Id = formItem != null ? formItem.Id : -1,
                Code = txt_code.Text.ToString(),
                FullName = txt_fullname.Text.ToString(),
                Address = txt_address.Text.ToString(),
                DOB = Convert.ToDateTime(datepicker_dob.Value.ToString()),
                PhoneNumber = txt_phone.Text.ToString(),
                Position = txt_position.Text.ToString(),
            };
            return item;
        }

        private void refreshList()
        {
            List<Manager> list = mainS.getAll(pagination.itemsPerPage, pagination.currentPage);
            refreshList(list);
        }

        private void refreshList(List<Manager> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Code, item.FullName,
                    item.Address, item.DOB, item.PhoneNumber, item.Position
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
            txt_position.Text = "";
            txt_phone.Text = "";
            datepicker_dob.Text = new DateTime(2000, 1, 1).ToString();
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
                    List<Manager> list = mainS.searchByKeyword(txt_search.Text);
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
