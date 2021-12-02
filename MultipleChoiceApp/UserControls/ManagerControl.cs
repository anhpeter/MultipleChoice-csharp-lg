using FluentValidation.Results;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Models;
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
    public partial class ManagerControl : UserControl
    {
        ManagerBUS mainBUS = new ManagerBUS();
        Manager formItem;
        public ManagerControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void ManagerControl_Load(object sender, EventArgs e)
        {
            refreshList();
        }


        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getSelectedId();
            if (id > -1)
            {
                formItem = mainBUS.getDetailsById(id);
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
            Manager item = getFormItem();
            if (handleValidation())
            {
                bool result = mainBUS.update(item);
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
            List<Manager> list = mainBUS.getAll();
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
        }

        private void clearForm()
        {
            txt_code.Text = "";
            txt_fullname.Text = "";
            txt_address.Text = "";
            txt_position.Text = "";
            txt_phone.Text = "";
            datepicker_dob.Text = new DateTime(2000,1,1).ToString();
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
                List<Manager> list = mainBUS.searchByKeyword(txt_search.Text);
                refreshList(list);
            }
        }

    }
}
