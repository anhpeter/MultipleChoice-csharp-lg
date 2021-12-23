using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
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

namespace MultipleChoiceApp.Forms
{
    public partial class FrmReportStudentByExam : Form
    {
        List<Exam> examList;
        ExamBUS examBUS = new ExamBUS();
        StudentResultBUS studentResultBUS = new StudentResultBUS();
        public FrmReportStudentByExam()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private int getExamId()
        {
            if (drop_exam.SelectedValue != null) return Util.parseToInt(drop_exam.SelectedValue.ToString(), -1);
            return -1;
        }

        private void FrmReportStudentBySubject_Load(object sender, EventArgs e)
        {
            if (examList == null) examList = examBUS.getAllForSelectData();
            drop_exam.DataSource = examList;
            drop_exam.ValueMember = "Id";
            drop_exam.DisplayMember = "Name";
            drop_exam.SelectedIndex = 0;

            loadReportData();
        }

        private void loadReportData()
        {
            List<StudentResultReport> list = getStudentResultReportList();
            ReportDataSource rds = new ReportDataSource("StudentResultReport", list);
            report.Reset();
            report.LocalReport.DataSources.Clear();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\StudentReportByExam.rdlc";
            report.LocalReport.DataSources.Add(rds);
            report.RefreshReport();
        }

        private List<StudentResultReport> getStudentResultReportList()
        {
            List<StudentResultReport> studentResultReportList = new List<StudentResultReport>();
            int examId = getExamId();
            List<StudentResult> studentResultList = studentResultBUS.getAllByExamId(examId);
            foreach (var item in studentResultList)
            {
                StudentResultReport studentReport = new StudentResultReport()
                {
                    Code = item.Student.Code,
                    FullName = item.Student.FullName,
                    Address = item.Student.Address,
                    DOB = Util.toExamFormattedDate(item.Student.DOB),
                    Major = item.Student.Major,
                    Points = item.Points,
                    ExamName = item.Exam.Name
                };
                studentResultReportList.Add(studentReport);
            }
            return studentResultReportList;
        }

        private void drop_exam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadReportData();
        }
    }
}
