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
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
