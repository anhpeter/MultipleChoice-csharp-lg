using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    class StudentResponse
    {
        public Question Question { get; set; }
        public int[] AnswerOrder { get; set; }
        public int AnswerNO { get; set; }
        //
        public int correctAnswerNo { get; set; }
        //
        public void genRandomOrder()
        {
            int[] orderArr = { 1, 2, 3, 4 };
            Random rnd = new Random();
            AnswerOrder = orderArr.OrderBy(x => rnd.Next()).ToArray();
            int correctAnswerNoIndex = Array.FindIndex(AnswerOrder, x => x == Question.CorrectAnswerNo);
            correctAnswerNo = AnswerOrder[correctAnswerNoIndex];
        }
    }
}
