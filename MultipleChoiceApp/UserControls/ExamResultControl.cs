﻿using FluentValidation.Results;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Forms;
using MultipleChoiceApp.Models;
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
    public partial class ExamResultControl : UserControl, IPagination
    {
        private bool loaded = false;
        String controlName = "Student Results";
        //
        ExamBUS examBUS = new ExamBUS();
        PaginationControl paginationControl;
        Pagination pagination = new Pagination(0, 1, 15, 3);
        Boolean searchMode = false;
        public ExamResultControl()
        {
            InitializeComponent();
        }
        private void ExamResultControl_Load(object sender, EventArgs e)
        {
            refreshList();
            clearForm();
            loaded = true;
        }
        // ACTIONS
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        // HELPER METHODS
        private void refreshList()
        {
            List<Exam> list = examBUS.getAllForReport();
            refreshList(list);
        }
        private void refreshList(List<Exam> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Name, item.StartAt,
                    item.EndAt, item.Status, item.StudentCount
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
        }
        async private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            //if (await FormHelper.getIdle(txt_search))
            //{
            //    String keyword = txt_search.Text;
            //    if (keyword.Trim() != "")
            //    {
            //        searchMode = true;
            //        List<Exam> list = mainBUS.searchByKeyword(txt_search.Text);
            //        refreshList(list);
            //    }
            //    else
            //    {
            //        searchMode = false;
            //        refreshList();
            //    }
            //}
        }
        public int count()
        {
            return 10;
            //return mainBUS.countAll();
        }
        public void onPage()
        {
            pagination = paginationControl.pagination;
            refreshList();
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

        private void gv_main_SelectionChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int id = getSelectedId();
                if (id > -1)
                {
                    Exam item = examBUS.getDetailsById(id);
                    if (item != null)
                    {
                        FrmExamReport frmExamReport = new FrmExamReport(item);
                        frmExamReport.ShowDialog();
                        this.Size = new Size(1536, 856);
                    }
                }
            }
        }
    }
}