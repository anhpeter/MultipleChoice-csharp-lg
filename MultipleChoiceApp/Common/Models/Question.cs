using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Models
{
    public class Question
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public String SubjectCode { get; set; }
        public String Level { get; set; }
        public int Chapter { get; set; }
        public int CorrectAnswerNo { get; set; }
        public DateTime CreatedAt { get; set; }
        //
        public String Lecturer { get; set; }

        public static Question fromDR(SqlDataReader dr)
        {
            Question item = new Question()
            {
                Id = Convert.ToInt32(Util.getDrValue(dr, "Id")),
                Content = Util.getDrValue(dr, "Content"),
                SubjectCode = Util.getDrValue(dr, "SubjectCode"),
                Level = Util.getDrValue(dr, "Level"),
                Chapter = Util.parseToInt(Util.getDrValue(dr, "Chapter"), -1),
                CreatedAt = Convert.ToDateTime(Util.getDrValue(dr, "CreatedAt")),
                Lecturer = Util.getDrValue(dr, "Lecturer"),
                CorrectAnswerNo = Util.parseToInt(Util.getDrValue(dr, "CorrectAnswerNo"), 1),
            };
            return item;
        }
        public List<Answer> Answers { get; set; }
    }
}
