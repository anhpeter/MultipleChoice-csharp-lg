using Bunifu.Framework.UI;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Bi.StudentResponse;
using MultipleChoiceApp.Common.UtilForms;
using MultipleChoiceApp.UserControls.ExamReportControls;
using MultipleChoiceApp.UserControls.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmStudentResponse : Form
    {
        private bool loaded = false;
        Bi.Exam.Exam exam;
        Bi.Subject.Subject subject;
        StudentResult studentResult;
        StudentResponseServiceSoapClient studentResponseS = new StudentResponseServiceSoapClient();
        SubjectApiServiceSoapClient subjectS = new SubjectApiServiceSoapClient();
        List<Bi.StudentResponse.StudentResponse> studentResponsesList;
        //
        int studentCount;
        public FrmStudentResponse(Bi.Exam.Exam exam, StudentResult studentResult, int studentCount)
        {
            InitializeComponent();
            FormHelper.setFormSizeRatioOfScreen(this, 0.85);
            CenterToScreen();
            this.exam = exam;
            this.studentCount = studentCount;
            this.subject = subjectS.getDetailsById(exam.SubjectId);
            this.studentResult = studentResult;
            studentResponsesList = studentResponseS.getAllByExamAndStudentId(exam.Id, studentResult.Student.Id);
        }
        // EVENTS
        private void FrmStudentResponse_Load(object sender, EventArgs e)
        {
            CorrectChartControl chart = new CorrectChartControl(studentResult.Points);
            chart.Dock = DockStyle.Fill;
            pnl_chart.Controls.Add(chart);
            gv_main.Columns[1].Width = 60;
            gv_main.Columns[4].Width = 200;
            //
            lbl_fullname.Text = studentResult.Student.FullName;
            lbl_rank.Text = $"{studentResult.Rank} of {studentCount}";
            lbl_points.Text = studentResult.Points.ToString();
            int answeredCount = subject.TotalQuestion - studentResult.UnansweredCount;
            lbl_answered.Text = $"{answeredCount} of {subject.TotalQuestion}";
            lbl_correct.Text = $"{correctCount()}/{subject.TotalQuestion}";
            lbl_code.Text = studentResult.Student.Code;
            //
            refreshList();
            loaded = true;
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void refreshList()
        {
            gv_main.Rows.Clear();
            int i = 0;
            foreach (var item in studentResponsesList)
            {
                String correctAns = item.Question.Answers[item.Question.CorrectAnswerNo - 1].Content;
                String answered = "No answer";
                if (item.AnswerNO > 0) answered = item.Question.Answers[item.AnswerNO - 1].Content;
                String resultStr = item.AnswerNO == item.Question.CorrectAnswerNo ? "Correct" : "Incorrect";
                gv_main.Rows.Add(new object[] {
                    item.Id, item.No, item.Question.Content,
                     answered, resultStr
                });
                gv_main.Rows[i].Cells[4].Style.ForeColor = item.AnswerNO == item.Question.CorrectAnswerNo ? Color.Green : Color.Red;
                i++;
            }
        }
        private int correctCount()
        {
            int count = 0;
            foreach(var item in studentResponsesList)
            {
                if (item.AnswerNO == item.Question.CorrectAnswerNo) count++;
            }
            return count;
        }

        private void gv_main_SelectionChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int id = Util.parseToInt(gv_main.SelectedRows[0].Cells[0].Value.ToString());
                Bi.StudentResponse.StudentResponse studentResponse = studentResponsesList.Where(x => x.Id == id).FirstOrDefault();
                StudentQuestionAnswer frm = new StudentQuestionAnswer(studentResponse);
                frm.ShowDialog();
            }
        }
    }
}
