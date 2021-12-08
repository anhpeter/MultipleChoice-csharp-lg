using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    public class StudentResult
    {
        public List<StudentResponse> StudentResponses { get; set; }
        public Subject Subject { get; set; }
        public Exam Exam { get; set; }
        public Double Points { get; set; }

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
