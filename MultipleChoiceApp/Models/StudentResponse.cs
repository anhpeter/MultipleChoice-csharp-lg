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
        public int RandomAnswerNo { get; set; }
        //

        public StudentResponse() { }
        public StudentResponse(Question question)
        {
            this.Question = question;
            this.QuestionId = question.Id;
        }

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
        public void genRandomOrder(Random rnd)
        {
            int[] orderArr = { 1, 2, 3, 4 };
            AnswerOrder = orderArr.OrderBy(x => rnd.Next(1000)).ToArray();
        }
        public bool isCorrect()
        {
            if (RandomAnswerNo <= 0) return false;
            return AnswerOrder[RandomAnswerNo - 1] == Question.CorrectAnswerNo;
        }

        public String getAnswerOrderString()
        {
            return string.Join("", AnswerOrder);
        }

        public void setRandomAnswerNo(int no)
        {
            RandomAnswerNo = no;
            AnswerNO = no > 0 ? AnswerOrder[no - 1] : 0;
        }
    }
}
