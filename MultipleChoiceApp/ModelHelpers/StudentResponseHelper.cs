using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleChoiceApp.ModelHelpers
{
    public class StudentResponseHelper
    {
        public static List<StudentResponse> genStudentResponseList(List<Bi.Question.Question> questions)
        {
            List<StudentResponse> studentResponseList = new List<StudentResponse>();
            Random rnd = new Random();
            foreach (var question in questions)
            {
                Bi.StudentResult.Question stuResQuestion = Util.cvtObj<Bi.Question.Question, Bi.StudentResult.Question>(question);
                StudentResponse studentResponse = new StudentResponse()
                {
                    Question = stuResQuestion,
                    QuestionId = question.Id
                };
                StudentResponseHelper.genRandomOrder(rnd, studentResponse);
                studentResponseList.Add(studentResponse);
            }
            return studentResponseList;
        }
        public static void genRandomOrder(Random rnd, StudentResponse item)
        {
            int[] orderArr = { 1, 2, 3, 4 };
            int[] randomOrderArr = orderArr.OrderBy(x => rnd.Next(1000)).ToArray();
            ArrayOfInt arr = new ArrayOfInt();
            foreach (var x in randomOrderArr)
            {
                arr.Add(x);
            }
            item.AnswerOrder = arr;
        }
        public static bool isCorrect(StudentResponse item)
        {
            //if (RandomAnswerNo <= 0) return false;
            return item.AnswerNO == item.Question.CorrectAnswerNo;
        }

        public static void setRandomAnswerNo(int no, StudentResponse item)
        {
            item.RandomAnswerNo = no;
            item.AnswerNO = no > 0 ? item.AnswerOrder[no - 1] : 0;
        }
    }
}
