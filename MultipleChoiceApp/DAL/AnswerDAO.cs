using MultipleChoiceApp.Models;
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
        public List<Answer> getAnswersWithAnswerCountByExamAndQuestionId(int examId, int questionId)
        {
            String sqlStr = string.Format(@"
                select ans.QuestionId, ans.Content, ans.No, ISNULL(ansSta.AswerCount, 0) as AnswerCount
                from Answers as ans left join
                (
                    select  stuRes.QuestionId, stuRes.AnswerNo as No, count(stuRes.AnswerNo) as AswerCount
                    from StudentResponses as stuRes inner join StudentResults as sr on (sr.Id = stuRes.StudentResultId)
                    where sr.ExamId = {0}
                    group by stuRes.QuestionId, stuRes.AnswerNo
                ) as ansSta on (ans.QuestionId = ansSta.QuestionId and	ans.No = ansSta.No) 
                where ans.QuestionId = {1}
                order by ans.No asc
                ", examId, questionId);
            return this.getAll(sqlStr);
        }
        public List<Answer> getAnswersByQuestionId(int id)
        {
            List<Answer> list = new List<Answer>();
            String sqlStr = $"Select * from {tableName} where QuestionId={id} order by No asc";
            return getAll(sqlStr);
        }

        // ADD
        public override int add(Answer item)
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
            int no = 1;
            foreach (Answer item in list)
            {
                item.No = no;
                item.QuestionId = questionId;
                if (add(item) < 1) result = false;
                no++;
            }
            return result;
        }

        // UPDATE
        public override bool update(Answer item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Content", item.Content);
            return base.updateWithDict(dataDict, $"WHERE QuestionId={item.QuestionId} AND No={item.No}");
        }

        public bool updateManyForQuestion(List<Answer> list)
        {
            bool result = false;
            foreach (Answer item in list)
            {
                bool updateResult = update(item);
                if (updateResult) result = true;
            }
            return result;
        }
    }
}
