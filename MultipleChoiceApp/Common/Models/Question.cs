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
            try
            {
                Question item = new Question()
                {
                    Id = (int)dr["Id"],
                    Content = (String)dr["Content"],
                    SubjectCode = (String)dr["SubjectCode"],
                    Level = (String)dr["Level"],
                    //Chapter = (String)dr["Chapter"],
                    CreatedAt = (DateTime)dr["CreatedAt"],
                    //
                    //Lecturer = (String)dr["Lecturer"],
                    //CorrectAnswerNo = (int)dr["CorrectAnswerNo"],
                };
                return item;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Question.fromDr:Failed " + ex.Message);
                return null;
            }
        }
        //
        public List<Answer> Answers { get; set; }
    }
}
