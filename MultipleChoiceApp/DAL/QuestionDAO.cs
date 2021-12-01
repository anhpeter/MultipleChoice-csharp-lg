using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class QuestionDAO : BaseDAO<Question>
    {
        public QuestionDAO() : base("Questions") { }

        // IMPLEMENT ABSTRACTS
        protected override Question fromDR(SqlDataReader dr)
        {
            return Question.fromDR(dr);
        }

        // FETCHS
        public List<Question> getAllBySubjectCode(String code)
        {
            List<Question> list = new List<Question>();
            try
            {
                String sqlStr = @"
                    SELECT DISTINCT 
                        q.Id, CAST(q.Content as nvarchar(255)) as Content, q.Chapter, Q.CreatedAt, s.Lecturer, s.Code as SubjectCode, 
                        q.Level
                    FROM Questions as q 
                        INNER JOIN Subjects as s ON (q.SubjectCode = s.Code)
                    WHERE s.Code = @code
                    ORDER BY q.Id DESC;
                ";
                SqlConnection con = dbHelper.getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sqlStr, con);
                com.Parameters.Add(new SqlParameter("@code", code));
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(Question.fromDR(dr));
                }
                con.Close();
                return list;
            }
            catch (Exception ex)
            {
                handleError(ex, "get-all-by-subject-code");
                return null;
            }
        }

        // UPDATE

        // ADD
        public int add(Question item)
        {
            try
            {
                String sqlStr = @"
                    INSERT INTO Questions(Content, SubjectCode, Level, CorrectAnswerNo) 
                        OUTPUT Inserted.Id
                        VALUES (@Content, @SubjectCode, @Level, @CorrectAnsNo);
                    ";
                SqlConnection con = dbHelper.getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sqlStr, con);
                com.Parameters.Add(new SqlParameter("@Content", item.Content));
                com.Parameters.Add(new SqlParameter("@SubjectCode", item.SubjectCode));
                com.Parameters.Add(new SqlParameter("@Level", item.Level));
                com.Parameters.Add(new SqlParameter("@CorrectAnsNo", item.CorrectAnswerNo));
                int newID = (int)com.ExecuteScalar();
                con.Close();
                return newID;
            }
            catch (Exception ex)
            {
                handleError(ex, "add");
                return -1;
            }
        }

        // DELETE

        // HELPER METHODS
    }
}
