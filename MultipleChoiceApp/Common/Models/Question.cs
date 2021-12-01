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
    class Question
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public String SubjectCode { get; set; }
        public String Level { get; set; }
        public String Chapter { get; set; }
        public int CorrectAnswerNo { get; set; }
        public DateTime CreatedAt { get; set; }
        //
        public String Lecturer { get; set; }

        public static Question fromDR(SqlDataReader dr)
        {
            Question item = new Question()
            {
                Id = Convert.ToInt32(DataHelper.getDrValue(dr, "Id")),
                Content = DataHelper.getDrValue(dr, "Content"),
                SubjectCode = DataHelper.getDrValue(dr, "SubjectCode"),
                Level = DataHelper.getDrValue(dr, "Level"),
                Chapter = DataHelper.getDrValue(dr, "Chapter"),
                CreatedAt = Convert.ToDateTime(DataHelper.getDrValue(dr, "CreatedAt")),
                Lecturer = DataHelper.getDrValue(dr, "Lecturer"),
                CorrectAnswerNo = Convert.ToInt32(DataHelper.getDrValue(dr, "CorrectAnswerNo", "1")),
            };
            return item;
        }
        public List<Answer> Answers { get; set; }
    }
}
