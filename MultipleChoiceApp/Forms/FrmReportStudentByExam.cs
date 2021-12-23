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
        StudentResultBUS studentResultBUS = new StudentResultBUS();
        public FrmReportStudentByExam()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmReportStudentBySubject_Load(object sender, EventArgs e)
        {
            report.RefreshReport();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\StudentReportByExam.rdlc";
            ReportDataSource rds = new ReportDataSource("StudentResultReport", getStudentResultReportList());
            report.LocalReport.DataSources.Add(rds);
            report.RefreshReport();
        }

        private List<StudentResultReport> getStudentResultReportList()
        {
            List<StudentResultReport> studentResultReportList = new List<StudentResultReport>();
            List<StudentResult> studentResultList = studentResultBUS.getAllByExamId(2);
            foreach(var item in studentResultList)
            {
                StudentResultReport studentReport = new StudentResultReport()
                {
                    Code = item.Student.Code,
                    FullName = item.Student.FullName,
                    Address = item.Student.Address,
                    DOB = Util.toExamFormattedDate(item.Student.DOB),
                    Major = item.Student.Major,
                    Points = item.Points
                };
                studentResultReportList.Add(studentReport);
            }
            return studentResultReportList;
        }
    }
}
