using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class AnswerDAO : BaseDAO<Answer>
    {
        public AnswerDAO() : base("Answers") { }

        protected override Answer fromDR(SqlDataReader dr)
        {
            return Answer.fromDR(dr);
        }

        // FETCHES
        public List<Answer> getAnswersByQuestionId(int id)
        {
            List<Answer> list = new List<Answer>();
            try
            {
                String sqlStr = $"Select * from {tableName} where QuestionId={id} order by No desc";
                SqlDataReader dr = dbHelper.execRead(sqlStr);
                while (dr.Read())
                {
                    list.Add(fromDR(dr));
                }
                dbHelper.closeConnection();
                return list;
            }
            catch (Exception ex)
            {
                handleError(ex, "get-answers-by-question-id");
                return null;
            }
        }

        // ADD
        public bool add(Answer item)
        {
            try
            {
                String sqlStr = @"
                        INSERT INTO Answers(QuestionId, No, Content) 
                            VALUES (@QuestionId, @No, @Content);
                        ";
                SqlConnection con = dbHelper.getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sqlStr, con);
                com.Parameters.Add(new SqlParameter("@QuestionId", item.QuestionId));
                com.Parameters.Add(new SqlParameter("@No", item.No));
                com.Parameters.Add(new SqlParameter("@Content", item.Content));
                int affectedRows = com.ExecuteNonQuery();
                con.Close();
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                handleError(ex, "add");
                return false;
            }
        }

        public bool addManyForQuestion(List<Answer> list, int questionId)
        {
            bool result = true;
            foreach (Answer item in list)
            {
                item.QuestionId = questionId;
                if (!add(item)) result = false;
            }
            return result;
        }
    }
}
