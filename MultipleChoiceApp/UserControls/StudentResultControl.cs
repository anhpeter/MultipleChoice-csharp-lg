using FluentValidation.Results;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MultipleChoiceApp.ModelHelpers;

namespace MultipleChoiceApp.UserControls
{
    public partial class StudentResultControl : UserControl, IPagination
    {
        String controlName = "Student Results";
        StudentResultServiceSoapClient mainS = new StudentResultServiceSoapClient();
        //
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public StudentResultControl()
        {
            InitializeComponent();
        }

        private void StudentResultControl_Load(object sender, EventArgs e)
        {
            refreshList();
            clearForm();
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = getSelectedId();
            //if (id > -1)
            //{
            //    formItem = mainS.getDetailsById(id);
            //    if (formItem != null)
            //    {
            //        txt_code.Text = formItem.Code.ToString();
            //        txt_fullname.Text = formItem.FullName.ToString();
            //        txt_address.Text = formItem.Address.ToString();
            //        txt_major.Text = formItem.Major.ToString();
            //        datepicker_dob.Text = formItem.DOB.ToString();
            //    }
            //}
        }


        // ACTIONS



        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }



        // HELPER METHODS
        private void refreshList()
        {
            List<StudentResult> list = mainS.getAll(pagination.itemsPerPage, pagination.currentPage);
            refreshList(list);
        }

        private void refreshList(List<StudentResult> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Student.Code, item.Student.FullName,
                    item.Student.Address, item.Student.DOB, item.Student.Major, 
                    item.Points, item.Subject.Name, item.Exam.Name
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
            //txt_code.Text = "";
            //txt_fullname.Text = "";
            //txt_address.Text = "";
            //txt_major.Text = "";
            //datepicker_dob.Text = new DateTime(2000, 1, 1).ToString();
            //formItem = null;
        }

        async private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (await FormHelper.getIdle(txt_search))
            {
                String keyword = txt_search.Text;
                if (keyword.Trim() != "")
                {
                    searchMode = true;
                    List<StudentResult> list = mainS.searchByKeyword(txt_search.Text);
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

        private void btn_export_excel_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = savefiledialog_excel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<StudentResult> list = mainS.getAll(1000,1);
                List<Dictionary<String, String>> dicList = list.Select(x => StudentResultHelper.toDictionary(x)).ToList();
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

    }
}
