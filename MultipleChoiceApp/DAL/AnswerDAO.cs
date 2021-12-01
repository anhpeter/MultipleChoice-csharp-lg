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
                String sqlStr = $"Select * from {tableName} where QuestionId={id} order by No asc";
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
        public int add(Answer item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("QuestionId", item.QuestionId + "");
            dataDict.Add("No", item.No + "");
            dataDict.Add("Content", item.Content);
            return addWithDic(dataDict);
        }

        public bool addManyForQuestion(List<Answer> list, int questionId)
        {
            bool result = true;
            foreach (Answer item in list)
            {
                item.QuestionId = questionId;
                if (add(item) < 1) result = false;
            }
            return result;
        }

        // UPDATE
        public bool update(Answer item)
        {
            try
            {
                Dictionary<String, String> dataDict = new Dictionary<String, String>();
                dataDict.Add("Content", item.Content);
                return base.updateWithDict(dataDict, $"WHERE QuestionId={item.QuestionId} AND No={item.No}");
            }
            catch (Exception ex)
            {
                handleError(ex, "update");
                return false;
            }
        }

        public bool updateManyForQuestion(List<Answer> list)
        {
            bool result = true;
            foreach (Answer item in list)
            {
                if (!update(item)) result = false;
            }
            return result;
        }
    }
}
