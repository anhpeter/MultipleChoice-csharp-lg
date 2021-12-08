using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    public class StudentResult
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public Double Points { get; set; }
        //
        public static StudentResult fromDR(SqlDataReader dr)
        {

            StudentResult item = new StudentResult()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                ExamId = Util.parseToInt(Util.getDrValue(dr, "ExamId"), -1),
                StudentId = Util.parseToInt(Util.getDrValue(dr, "StudentId"), -1),
                Points = Util.parseToDouble(Util.getDrValue(dr, "Points"), 0)
            };
            return item;
        }
        public List<StudentResponse> StudentResponses { get; set; }
        public Subject Subject { get; set; }
        public Exam Exam { get; set; }

        public StudentResult() { }
        public StudentResult(List<StudentResponse> studentResponses, Subject subject, Exam exam)
        {
            this.StudentResponses = studentResponses;
            this.Subject = subject;
            this.Exam = exam;
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
                }
            }
            Points = points;
        }
    }
}
