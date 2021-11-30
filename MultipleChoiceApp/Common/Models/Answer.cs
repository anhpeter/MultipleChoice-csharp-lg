using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Models
{
    class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int No { get; set; }
        public String Content { get; set; }
        public static Answer fromDR(SqlDataReader dr)
        {
            Answer item = new Answer()
            {
                Id = (int)dr["Id"],
                QuestionId = (int)dr["QuestionId"],
                No = (int)dr["No"],
                Content = (String)dr["Content"],
            };
            return item;
        }
    }

}
