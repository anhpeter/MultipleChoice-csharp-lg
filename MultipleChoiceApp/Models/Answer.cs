using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Models
{
    public class Answer
    {
        public int QuestionId { get; set; }
        public int No { get; set; }
        public String Content { get; set; }
        public static Answer fromDR(SqlDataReader dr)
        {
            Answer item = new Answer()
            {
                QuestionId = Convert.ToInt32(Util.getDrValue(dr, "QuestionId")),
                No = Convert.ToInt32(Util.getDrValue(dr, "No")),
                Content = Util.getDrValue(dr, "Content"),
            };
            return item;
        }
    }

}
