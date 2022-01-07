using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    class ExamHelper
    {
        public static void genFileReportViewer(ReportViewer viewer, string filePath, string format)
        {

            string deviceInfo = "";
            string[] streamIds;
            Warning[] warnings;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            viewer.RefreshReport();
            var bytes = viewer.LocalReport.Render(format, deviceInfo, out mimeType, out encoding,
                out extension, out streamIds, out warnings);
            File.WriteAllBytes(filePath, bytes);
        }
        public static ExamSheet genExamSheet(Bi.Exam.Exam exam)
        {
            ExamSheet examSheet =
                 new ExamSheet()
                 {
                     ExamName = exam.Name,
                     Subject = exam.Subject.Name,
                     Semester = exam.Semester.ToString(),
                     Duration = exam.Subject.Duration.ToString(),
                     TotalQuestion = exam.Subject.TotalQuestion.ToString()
                 };
            return examSheet;
        }
        public static List<QuestionInExamSheet> genQuestionInExamList(Bi.Exam.Exam exam)
        {
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
            return questionInExamSheets;
        }

        public static int getNormalQty(Bi.Exam.Exam ex, int totalQuestion)
        {
            int qty = totalQuestion - (ex.EasyQty + ex.HardQty);
            return qty;
        }
        public static int getNormalQty(Bi.Exam.Exam ex)
        {
            int qty = ex.Subject.TotalQuestion - (ex.EasyQty + ex.HardQty);
            return qty;
        }
    }
}
