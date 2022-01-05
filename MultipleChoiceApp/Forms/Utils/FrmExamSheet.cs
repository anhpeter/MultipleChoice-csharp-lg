using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.ModelHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms.Utils
{
    public partial class FrmExamSheet : Form
    {

        Bi.Exam.Exam exam;
        public FrmExamSheet(Bi.Exam.Exam exam)
        {
            InitializeComponent();
            //
            Rectangle screen = Screen.FromControl(this).Bounds;
            Width = Convert.ToInt32(screen.Width * 0.6);
            Height = screen.Height - 50;
            CenterToScreen();
            this.exam = exam;
        }

        private void FrmExamSheet_Load(object sender, EventArgs e)
        {
            loadReportData();

        }
        private void loadReportData()
        {
            List<ModelHelpers.ExamSheet> examSheet = new List<ModelHelpers.ExamSheet>() {
                 new ModelHelpers.ExamSheet() {
                     SheetCode =1,
                     ExamName = exam.Name,
                     Subject = exam.Subject.Name,
                     Semester = exam.Semester.ToString(),
                     Duration = exam.Subject.Duration.ToString(),
                     TotalQuestion = exam.Subject.TotalQuestion.ToString()
                 }
            };

            List<Bi.Question.Question> questionList = QuestionHelper.genQuestionListForExam(exam.EasyQty, ExamHelper.getNormalQty(exam), exam.HardQty, exam.SubjectId);
            List<StudentResponse> studentResponseList = StudentResponseHelper.genStudentResponseList(questionList);
            List<QuestionInExamSheet> questionInExamSheets = studentResponseList.Select((stuRes, i) =>
            {
                Bi.StudentResult.Question question = stuRes.Question;
                int[] answerOrder = stuRes.AnswerOrder.ToArray();
                return new QuestionInExamSheet()
                {
                    No = i + 1,
                    Question = question.Content,
                    A = question.Answers[answerOrder[0] - 1].Content,
                    B = question.Answers[answerOrder[1] - 1].Content,
                    C = question.Answers[answerOrder[2] - 1].Content,
                    D = question.Answers[answerOrder[3] - 1].Content,
                };
            }).ToList();
            ReportDataSource examSheetDS = new ReportDataSource("ExamSheet", examSheet);
            ReportDataSource questionInExamSheetDS = new ReportDataSource("QuestionInExamSheet", questionInExamSheets);
            report.Reset();
            report.LocalReport.DataSources.Clear();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\Reports\ExamSheet.rdlc";
            report.LocalReport.DataSources.Add(examSheetDS);
            report.LocalReport.DataSources.Add(questionInExamSheetDS);
            report.RefreshReport();

        }

    }
}
