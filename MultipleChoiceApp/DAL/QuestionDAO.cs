using MultipleChoiceApp.Common.Helpers;
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
        // COUNT
        public int countBySubjectId(int id)
        {
            String sql = string.Format(@"
                    SELECT COUNT(*)
                    FROM Questions as q INNER JOIN Subjects as s ON (q.SubjectId = s.Id)
                    WHERE s.Id = '{0}'", id + "");
            return count(sql);
        }

        // FETCHS
        public List<Question> getRandomByLevel(String level, int qty)
        {
            List<Question> list = new List<Question>();
            String sqlStr = string.Format(@"
                SELECT * 
                FROM {0}
                WHERE Level='{1}'
                ORDER BY NEWID()
                OFFSET 0 ROWS FETCH NEXT {2} ROWS ONLY
            ", tableName, level, qty);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            while (dr.Read())
            {
                list.Add(Question.fromDR(dr));
            }
            dbHelper.closeConnection();
            return list;
        }
        public List<Question> getAllBySubjectId(int id, Pagination p)
        {
            List<Question> list = new List<Question>();
            String sqlStr = getAllBySujectIdSqlStr(id);
            SqlDataReader dr = dbHelper.execRead(applyPagination(sqlStr, p));
            while (dr.Read())
            {
                list.Add(Question.fromDR(dr));
            }
            dbHelper.closeConnection();
            return list;
        }
        public List<Question> getAllBySubjectId(int id)
        {
            List<Question> list = new List<Question>();
            String sqlStr = getAllBySujectIdSqlStr(id);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            while (dr.Read())
            {
                list.Add(Question.fromDR(dr));
            }
            dbHelper.closeConnection();
            return list;
        }

        public List<Question> searchByKeyWord(int id, String keyword)
        {
            List<Question> list = new List<Question>();
            String searchCondStr = string.Format("AND q.Content like '%{0}%'", keyword);
            String sqlStr = getAllBySujectIdSqlStr(id, searchCondStr);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            while (dr.Read())
            {
                list.Add(Question.fromDR(dr));
            }
            dbHelper.closeConnection();
            return list;
        }

        private String getAllBySujectIdSqlStr(int id, String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                    SELECT DISTINCT 
                        q.Id, CAST(q.Content as nvarchar(255)) as Content, q.CorrectAnswerNo, q.Chapter, q.CreatedAt, s.Lecturer, s.Code as SubjectCode, 
                        q.Level
                    FROM Questions as q INNER JOIN Subjects as s ON (q.SubjectId = s.Id)
                    WHERE s.Id = '{0}' {1}
                    ORDER BY q.Id DESC
                ", id, otherWhereStr);
            return sqlStr;
        }

        // ADD
        public int add(Question item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Content", item.Content);
            dataDict.Add("SubjectId", item.SubjectId + "");
            dataDict.Add("Level", item.Level);
            dataDict.Add("CorrectAnswerNo", item.CorrectAnswerNo + "");
            dataDict.Add("Chapter", item.Chapter + "");
            return addWithDic(dataDict, true);
        }

        // UPDATE
        public bool update(Question item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Content", item.Content);
            dataDict.Add("SubjectId", item.SubjectId + "");
            dataDict.Add("Level", item.Level);
            dataDict.Add("CorrectAnswerNo", item.CorrectAnswerNo + "");
            dataDict.Add("Chapter", item.Chapter + "");
            return base.updateWithDict(dataDict, $"WHERE Id={item.Id}");
        }

        // DELETE
    }
}
