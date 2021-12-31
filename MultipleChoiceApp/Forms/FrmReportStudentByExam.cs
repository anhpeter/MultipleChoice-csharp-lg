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
        String sortField = "StudentFullName";
        String sortValue = "asc";
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
            initDrops();
            loadReportData();
        }

        private void initDrops()
        {
            //
            drop_exam.DataSource = examList;
            drop_exam.ValueMember = "Id";
            drop_exam.DisplayMember = "Name";
            drop_exam.SelectedIndex = 0;
            //
            Dictionary<string, string> sortDic = new Dictionary<string, string>();
            sortDic.Add("StudentFullName_asc", "Student name ascending");
            sortDic.Add("StudentFullName_desc", "Student name descending");
            sortDic.Add("Points_asc", "Points ascending");
            sortDic.Add("points_desc", "Points descending");
            drop_sort.DataSource = new BindingSource(sortDic, null);
            drop_sort.DisplayMember = "Value";
            drop_sort.ValueMember = "Key";
        }

        private void loadReportData()
        {
            exam = examS.getExamReportById(getExamId());
            List<ModelHelpers.ExamReport> examReport = new List<ModelHelpers.ExamReport>() {
                 new ModelHelpers.ExamReport() { 
                     Name = exam.Name,
                     Subject = exam.Subject.Name,
                     StartAt = Util.toMediumDateStr(exam.StartAt),
                     EndAt = Util.toMediumDateStr(exam.EndAt),
                 }
            };

            List<ModelHelpers.StudentResultReport> list = getStudentResultReportList();
            ReportDataSource examRds = new ReportDataSource("ExamReport", examReport);
            ReportDataSource rds = new ReportDataSource("StudentResultReport", list);
            report.Reset();
            report.LocalReport.DataSources.Clear();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\Reports\StudentReportByExam.rdlc";
            report.LocalReport.DataSources.Add(rds);
            report.LocalReport.DataSources.Add(examRds);
            report.RefreshReport();
        }

        private List<ModelHelpers.StudentResultReport> getStudentResultReportList()
        {
            List<ModelHelpers.StudentResultReport> studentResultReportList = new List<ModelHelpers.StudentResultReport>();
            int examId = getExamId();
            List<StudentResult> studentResultList = studentResultS.getReportByExamId(examId, sortField, sortValue);
            int i = 0;
            foreach (var item in studentResultList)
            {
                ModelHelpers.StudentResultReport studentReport = new ModelHelpers.StudentResultReport()
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

        private void drop_sort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String value = drop_sort.SelectedValue.ToString();
            string[] split = value.Split('_');
            sortField = split[0];
            sortValue = split[1];
            loadReportData();
        }
    }
}
