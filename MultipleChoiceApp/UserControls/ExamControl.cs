using FluentValidation.Results;
using MultipleChoiceApp.BLL;
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
    public partial class ExamControl : UserControl,IPagination
    {
        ExamBUS mainBUS = new ExamBUS();
        SubjectBUS subjectBUS = new SubjectBUS();
        Exam formItem;
        List<Subject> subjectList;
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public ExamControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ExamControl_Load(object sender, EventArgs e)
        {
            datepicker_start_at.Format = DateTimePickerFormat.Custom;
            datepicker_start_at.CustomFormat = "dd/MM/yyyy hh:mm";
            datepicker_end_at.Format = DateTimePickerFormat.Custom;
            datepicker_end_at.CustomFormat = "dd/MM/yyyy hh:mm";
            loadDrops();
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
                    txt_name.Text = formItem.Name.ToString();
                    txt_semester.Text = formItem.Semester.ToString();
                    txt_easy_qty.Text = formItem.EasyQty.ToString();
                    txt_hard_qty.Text = formItem.HardQty.ToString();
                    datepicker_start_at.Text = formItem.StartAt.ToString();
                    datepicker_end_at.Text = formItem.EndAt.ToString();
                    drop_subject.SelectedValue = formItem.SubjectId;
                }
            }
        }


        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Exam question = getFormItem();
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
            Exam item = getFormItem();
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
            Exam item = getFormItem();
            ExamValidator validator = new ExamValidator();
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
        private Exam getFormItem()
        {
            // ANSWER LIST
            Subject subject = subjectList.Find(x => x.Id == getFormSubjectId());
            Exam item = new Exam()
            {
                Id = formItem != null ? formItem.Id : -1,
                Name = txt_name.Text.ToString(),
                Semester = Util.parseToInt(txt_semester.Text.ToString(), -1),
                SubjectId = subject.Id,
                EasyQty = Util.parseToInt(txt_easy_qty.Text.ToString(), -1),
                HardQty = Util.parseToInt(txt_hard_qty.Text.ToString(), -1),
                StartAt = Convert.ToDateTime(datepicker_start_at.Value.ToString()),
                EndAt = Convert.ToDateTime(datepicker_end_at.Value.ToString()),
                Subject = subject
            };
            return item;
        }

        private void refreshList()
        {
            List<Exam> list = mainBUS.getAll(pagination);
            refreshList(list);
        }

        private void refreshList(List<Exam> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Name, item.Semester,
                    item.SubjectCode, item.EasyQty, item.HardQty, item.TotalQuestion,
                    item.StartAt, item.EndAt
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
            txt_name.Text = "";
            txt_semester.Text = "";
            txt_easy_qty.Text = "0";
            txt_hard_qty.Text = "0";
            datepicker_start_at.Text = DateTime.Now.ToString();
            datepicker_end_at.Text = DateTime.Now.ToString();
            drop_subject.SelectedIndex = 0;
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
                    List<Exam> list = mainBUS.searchByKeyword(txt_search.Text);
                    refreshList(list);
                }
                else
                {
                    searchMode = false;
                    refreshList();
                }
            }
        }

        private void loadDrops()
        {
            // SUBJECTS
            if (subjectList == null) subjectList = subjectBUS.getAllForSelectData();
            if (subjectList.Count > 0)
            {
                drop_subject.DataSource = subjectList;
                drop_subject.ValueMember = "Id";
                drop_subject.DisplayMember = "Name";
                drop_subject.SelectedIndex = 0;
            }

        }

        private int getFormSubjectId()
        {
            return Util.parseToInt(drop_subject.SelectedValue.ToString(), -1);
        }

        public int count()
        {
            return mainBUS.countAll();
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
        }
    }
}
