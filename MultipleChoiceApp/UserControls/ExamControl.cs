using FluentValidation.Results;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class ExamControl : UserControl, IPagination,IAdminUserControl
    {
        ExamServiceSoapClient mainS = new ExamServiceSoapClient();
        SubjectServiceSoapClient subjectS = new SubjectServiceSoapClient();
        Exam formItem;
        List<Bi.Subject.Subject> subjectList;
        List<Exam> examList;
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public ExamControl()
        {
            InitializeComponent();
        }

        private void ExamControl_Load(object sender, EventArgs e)
        {
            datepicker_start_at.Format = DateTimePickerFormat.Custom;
            datepicker_start_at.CustomFormat = "dd/MM/yyyy HH:mm";
            datepicker_end_at.Format = DateTimePickerFormat.Custom;
            datepicker_end_at.CustomFormat = "dd/MM/yyyy HH:mm";
            loadDrops();
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
            Exam item = getFormItem();
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
            Exam item = getFormItem();
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
            Bi.Subject.Subject subject = subjectList.Find(x => x.Id == getFormSubjectId());
            Bi.Exam.Subject exSub = Util.cvtObj<Bi.Subject.Subject, Bi.Exam.Subject>(subject);
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
                Subject = exSub
            };
            return item;
        }

        public void refreshList()
        {
            examList = mainS.getAll(pagination.itemsPerPage, pagination.currentPage);
            refreshList(examList);
        }

        public void refreshList(List<Exam> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Name, item.Semester,
                    item.SubjectCode,  item.TotalQuestion, item.StudentCount,
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
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, now.Month, now.Day, 7, 0, 0, 0);
            DateTime end = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0, 0);

            datepicker_start_at.Text = start.ToString();
            datepicker_end_at.Text = end.ToString();
            drop_subject.SelectedIndex = 0;
            formItem = null;
        }

        private Exam getItemByRowIndex(int index)
        {
            int id = getIdByRowIndex(index);
            if (id > -1)
            {
                return examList.Find(x => x.Id == id);
            }
            return null;
        }

        private int getIdByRowIndex(int rowIndex)
        {
            try
            {
                return Util.parseToInt(gv_main.Rows[rowIndex].Cells[0].Value.ToString(), -1);
            }
            catch (Exception ex)
            {
                return -1;
            }
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
                    examList = mainS.searchByKeyword(txt_search.Text);
                    refreshList(examList);
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
            if (subjectList == null) subjectList = subjectS.getAllForSelectData();
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
            return mainS.countAll();
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
        }

        private void gv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //new FrmExamDetails().ShowDialog();
        }

        // ROW ACTIONS
        private void viewInfo(object sender, EventArgs e, int rowIndex)
        {
            Exam item = getItemByRowIndex(rowIndex);
            new FrmExamInfo(this, item).ShowDialog();
        }

        private void mapStudents(object sender, EventArgs e, int rowIndex)
        {
            Exam item = getItemByRowIndex(rowIndex);
            new FrmExamMapping(this, item).ShowDialog();
        }

        // CONTEXT MENU FOR GRID ROWS
        private void gv_main_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = gv_main.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    //
                    MenuItem viewInfoItem = new MenuItem("View Info");
                    viewInfoItem.Click += (s, ev) => viewInfo(s, ev, currentMouseOverRow);
                    //
                    MenuItem mapStudentsItem = new MenuItem("Map students");
                    mapStudentsItem.Click += (s, ev) => mapStudents(s, ev, currentMouseOverRow);
                    //
                    m.MenuItems.Add(viewInfoItem);
                    m.MenuItems.Add(mapStudentsItem);
                    m.Show(gv_main, new Point(e.X, e.Y));
                }
            }
        }

        // HELPER METHODS
    }
}
