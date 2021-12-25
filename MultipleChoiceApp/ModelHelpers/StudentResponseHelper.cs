using MultipleChoiceApp.Bi.StudentResult;
using System;
using System.Linq;

namespace MultipleChoiceApp.ModelHelpers
{
    public class StudentResponseHelper
    {

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
