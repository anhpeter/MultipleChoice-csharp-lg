using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    public class StudentResponse
    {
        public int StudentResultId { get; set; }
        public int QuestionId { get; set; }
        //
        public Question Question { get; set; }
        public int[] AnswerOrder { get; set; }
        public int AnswerNO { get; set; }
        //
        public int CorrectAnswerNo { get; set; }
        //
        public static StudentResponse fromDR(SqlDataReader dr)
        {

            int[] answerOrderArr = { };
            String answerOrder = Util.getDrValue(dr, "AnswerOrder");
            if (answerOrder != null)
            {
                answerOrderArr = answerOrder.ToCharArray().Select(x => Util.parseToInt(x + "", 1)).ToArray();
            }
            StudentResponse item = new StudentResponse()
            {
                StudentResultId = Util.parseToInt(Util.getDrValue(dr, "StudentResultId"), -1),
                QuestionId = Util.parseToInt(Util.getDrValue(dr, "QuestionId"), -1),
                AnswerOrder = answerOrderArr,
                AnswerNO = Util.parseToInt(Util.getDrValue(dr, "AnswerNo"), -1),
            };
            return item;
        }
        public void genRandomOrder()
        {
            int[] orderArr = { 1, 2, 3, 4 };
            Random rnd = new Random();
            AnswerOrder = orderArr.OrderBy(x => rnd.Next()).ToArray();
            int correctAnswerNoIndex = Array.FindIndex(AnswerOrder, x => x == Question.CorrectAnswerNo);
            CorrectAnswerNo = correctAnswerNoIndex + 1;
        }
        public bool isCorrect()
        {
            return CorrectAnswerNo == AnswerNO;
        }

        public String getAnswerOrderString()
        {
            return string.Join("", AnswerOrder);
        }
    }
}
