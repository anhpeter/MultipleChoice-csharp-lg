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
    public partial class SubjectControl : UserControl
    {
        SubjectBUS mainBUS = new SubjectBUS();
        Subject formItem;

        public SubjectControl()
        {
            InitializeComponent();
            this.MaximumSize = new Size(700, 1000);
        }

        private void SubjectControl_Load(object sender, EventArgs e)
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
            Subject item = getFormItem();
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
            List<Subject> list = mainBUS.getAll();
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
                List<Subject> list = mainBUS.searchByKeyword(txt_search.Text);
                refreshList(list);
            }
        }
    }
}
