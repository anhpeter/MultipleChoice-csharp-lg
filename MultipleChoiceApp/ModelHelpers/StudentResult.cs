using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    public class StudentResult
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public Double Points { get; set; }
        public DateTime CreatedAt { get; set; }
        //
        public int CorrectAnswerCount { get; set; }
        public int IncorrectAnswerCount { get; set; }
        public int UnansweredCount { get; set; }
        public int Rank { get; set; }
        //
        public Subject Subject { get; set; }
        public Exam Exam { get; set; }
        public Student Student { get; set; }
        //
        public static StudentResult fromDR(SqlDataReader dr)
        {
            Subject subject = new Subject()
            {
                Name = Util.getDrValue(dr, "SubjectName"),
            };
            Exam exam = new Exam()
            {
                Name = Util.getDrValue(dr, "ExamName"),
            };
            Student student = new Student()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "StudentId")),
                Code = Util.getDrValue(dr, "StudentCode"),
                FullName = Util.getDrValue(dr, "StudentFullName"),
                Address = Util.getDrValue(dr, "StudentAddress"),
                Major = Util.getDrValue(dr, "StudentMajor"),
                DOB = Util.parseToDatetime(Util.getDrValue(dr, "StudentDOB")),
            };

            StudentResult item = new StudentResult()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                ExamId = Util.parseToInt(Util.getDrValue(dr, "ExamId"), -1),
                StudentId = Util.parseToInt(Util.getDrValue(dr, "StudentId"), -1),
                Points = Util.parseToDouble(Util.getDrValue(dr, "Points"), 0),
                UnansweredCount = Util.parseToInt(Util.getDrValue(dr, "UnansweredCount")),
                Rank = Util.parseToInt(Util.getDrValue(dr, "Rank")),
                CreatedAt = Util.parseToDatetime(Util.getDrValue(dr, "Rank")),
                //
                Subject = subject,
                Exam = exam,
                Student = student,
            };
            return item;
        }
        public List<StudentResponse> StudentResponses { get; set; }

        public StudentResult() { }
        public StudentResult(List<StudentResponse> studentResponses, Subject subject, Exam exam, int studentId)
        {
            this.StudentResponses = studentResponses;
            this.Subject = subject;
            this.Exam = exam;
            this.ExamId = exam.Id;
            this.StudentId = studentId;
            calculatePoints();
        }
        //
        public void calculatePoints()
        {
            Double points = 0;
            foreach (var studentResponse in StudentResponses)
            {
                if (studentResponse.isCorrect())
                {
                    points += 10.0 / Subject.TotalQuestion;
                    CorrectAnswerCount++;
                }
                else
                {
                    IncorrectAnswerCount++;
                }
            }
            Points = points;
        }

        //
        public Dictionary<String, String> toDictionary()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", this.Id + "");
            dic.Add("Student Code", this.Student.Code);
            dic.Add("Full Name", this.Student.FullName);
            dic.Add("Address", this.Student.Address);
            dic.Add("Day Of Birth", Util.toSqlFormattedDate(this.Student.DOB));
            dic.Add("Major", this.Student.Major);
            dic.Add("Points", this.Points+"");
            dic.Add("Subject", this.Subject.Name);
            dic.Add("Exam", this.Exam.Name);
            return dic;
        }
    }
}
