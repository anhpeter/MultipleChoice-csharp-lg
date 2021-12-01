﻿using MultipleChoiceApp.Common.Helpers;
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
                String sqlStr = String.Format(@"
                    SELECT DISTINCT 
                        q.Id, CAST(q.Content as nvarchar(255)) as Content, q.Chapter, Q.CreatedAt, s.Lecturer, s.Code as SubjectCode, 
                        q.Level
                    FROM Questions as q 
                        INNER JOIN Subjects as s ON (q.SubjectCode = s.Code)
                    WHERE s.Code = '{0}'
                    ORDER BY q.Id DESC;
                ", code);
                SqlDataReader dr = dbHelper.execRead(sqlStr);
                while (dr.Read())
                {
                    list.Add(Question.fromDR(dr));
                }
                dbHelper.closeConnection();
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
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Content", item.Content);
            dataDict.Add("SubjectCode", item.SubjectCode);
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
            dataDict.Add("SubjectCode", item.SubjectCode);
            dataDict.Add("Level", item.Level);
            dataDict.Add("CorrectAnswerNo", item.CorrectAnswerNo + "");
            dataDict.Add("Chapter", item.Chapter + "");
            return base.updateWithDict(dataDict, $"WHERE Id={item.Id}");
        }
    }
}