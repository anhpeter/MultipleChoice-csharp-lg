using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Common.Helpers;
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
        ExamServiceSoapClient examS = new ExamServiceSoapClient();
        List<Bi.Exam.Exam> examList;
        Bi.Exam.Exam exam;
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
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
            if (examList == null) examList = examS.getAllForSelectData();
            drop_exam.DataSource = examList;
            drop_exam.ValueMember = "Id";
            drop_exam.DisplayMember = "Name";
            drop_exam.SelectedIndex = 0;

            loadReportData();
        }

        private void loadReportData()
        {
            exam = examS.getExamReportById(getExamId());
            List<Models.ExamReport> examReport = new List<Models.ExamReport>() {
                 new Models.ExamReport() { 
                     Name = exam.Name,
                     Subject = exam.Subject.Name,
                     StartAt = Util.toMediumDateStr(exam.StartAt),
                     EndAt = Util.toMediumDateStr(exam.EndAt),
                 }
            };

            List<Models.StudentResultReport> list = getStudentResultReportList();
            ReportDataSource examRds = new ReportDataSource("ExamReport", examReport);
            ReportDataSource rds = new ReportDataSource("StudentResultReport", list);
            report.Reset();
            report.LocalReport.DataSources.Clear();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\Reports\StudentReportByExam.rdlc";
            report.LocalReport.DataSources.Add(rds);
            report.LocalReport.DataSources.Add(examRds);
            report.RefreshReport();
        }

        private List<Models.StudentResultReport> getStudentResultReportList()
        {
            List<Models.StudentResultReport> studentResultReportList = new List<Models.StudentResultReport>();
            int examId = getExamId();
            List<StudentResult> studentResultList = studentResultS.getAllByExamId(examId);
            int i = 0;
            foreach (var item in studentResultList)
            {
                Models.StudentResultReport studentReport = new Models.StudentResultReport()
                {
                    No = i + 1,
                    Code = item.Student.Code,
                    FullName = item.Student.FullName,
                    Address = item.Student.Address,
                    DOB = Util.toMediumDateStr(item.Student.DOB),
                    Major = item.Student.Major,
                    Points = item.Points,
                    ExamName = item.Exam.Name
                };
                studentResultReportList.Add(studentReport);
                i++;
            }
            return studentResultReportList;
        }

        private void drop_exam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadReportData();
        }
    }
}
