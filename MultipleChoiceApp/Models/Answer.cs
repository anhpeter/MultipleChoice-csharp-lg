using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    public class Answer
    {
        public int QuestionId { get; set; }
        public int No { get; set; }
        public String Content { get; set; }
        //
        public int AnswerCount { get; set; }
        public static Answer fromDR(SqlDataReader dr)
        {
            Answer item = new Answer()
            {
                QuestionId = Util.parseToInt(Util.getDrValue(dr, "QuestionId")),
                No = Util.parseToInt(Util.getDrValue(dr, "No")),
                Content = Util.getDrValue(dr, "Content"),
                //
                AnswerCount = Util.parseToInt(Util.getDrValue(dr, "AnswerCount")),
            };
            return item;
        }
    }

}
