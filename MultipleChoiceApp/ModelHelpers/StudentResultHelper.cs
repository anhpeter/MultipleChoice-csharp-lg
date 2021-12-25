using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.StudentResult;
using System;
using System.Collections.Generic;

namespace MultipleChoiceApp.ModelHelpers
{
    public class StudentResultHelper
    {
        public static StudentResult genStudentResult(List<StudentResponse> studentResponses, Subject subject, Exam exam, int studentId)
        {
            StudentResult item = new StudentResult()
            {
                StudentResponses = studentResponses,
                Subject = subject,
                Exam = exam,
                ExamId = exam.Id,
                StudentId = studentId
            };
            StudentResultHelper.calculatePoints(item);
            return item;
        }
        //
        private static void calculatePoints(StudentResult item)
        {
            Double points = 0;
            foreach (var studentResponse in item.StudentResponses)
            {
                if (StudentResponseHelper.isCorrect(studentResponse))
                {
                    points += 10.0 / item.Subject.TotalQuestion;
                    item.CorrectAnswerCount++;
                }
                else
                {
                    item.IncorrectAnswerCount++;
                }
            }
            item.Points = points;
        }

        //
        public static Dictionary<String, String> toDictionary(StudentResult item)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", item.Id + "");
            dic.Add("Student Code", item.Student.Code);
            dic.Add("Full Name", item.Student.FullName);
            dic.Add("Address", item.Student.Address);
            dic.Add("Day Of Birth", Util.toSqlFormattedDate(item.Student.DOB));
            dic.Add("Major", item.Student.Major);
            dic.Add("Points", item.Points + "");
            dic.Add("Subject", item.Subject.Name);
            dic.Add("Exam", item.Exam.Name);
            return dic;
        }
    }
}
