using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class ExamDAO : BaseDAO<Exam>
    {
        public ExamDAO() : base("Exams")
        {
            this.primaryKey = "Id";
        }

        // IMPLEMENT ABSTRACTS
        protected override Exam fromDR(SqlDataReader dr)
        {
            return Exam.fromDR(dr);
        }
        //
        public bool isAvailableBetweenDate(DateTime start, DateTime end, int subjectId)
        {
            String startStr = Util.toSqlFormattedDate(start);
            String endStr = Util.toSqlFormattedDate(end);
            String sqlStr = string.Format(
                @"SELECT * FROM {0}
                WHERE ('{1}' AS DATE BETWEEN StartAt ) 
                AND EndAt)
                AND SubjectId = '{3}'
            ",  tableName, startStr, endStr, subjectId);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            bool hasItems = dr.HasRows;
            return !hasItems;
        }

        // FETCHS
        public Exam getAvailabelBySubjectId(int subjectId, DateTime d)
        {
            Exam item = null;
            String sqlStr = string.Format(@"
                select *
                from Exams as e inner join Subjects as s on (s.Id = e.SubjectId)
                where 
                    s.Id = '{0}' and
                    e.StartAt <= '{1}' and
                    e.EndAt >= '{1}'
                ", subjectId+"", d.ToString());
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = Exam.fromDR(dr);
            }
            return item;

        }
        public List<Exam> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where e.Name like '%{keyword}%'");
            return getAll(sqlStr);
        }

        protected override String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                    SELECT DISTINCT e.*, s.Code as SubjectCode, s.TotalQuestion as TotalQuestion
                    FROM Exams as e
                        INNER JOIN Subjects as s ON (e.SubjectId = s.Id)
                        {0}
                    ORDER BY e.Id DESC
                ", otherWhereStr);
            return sqlStr;
        }

        // ADD
        public override int add(Exam item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Name", item.Name);
            dataDict.Add("Semester", item.Semester + "");
            dataDict.Add("SubjectId", item.SubjectId + "");
            dataDict.Add("StartAt", Util.toSqlFormattedDate(item.StartAt));
            dataDict.Add("EndAt", Util.toSqlFormattedDate(item.EndAt));
            dataDict.Add("EasyQty", item.EasyQty + "");
            dataDict.Add("HardQty", item.HardQty + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public override bool update(Exam item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Name", item.Name);
            dataDict.Add("Semester", item.Semester + "");
            dataDict.Add("SubjectId", item.SubjectId + "");
            dataDict.Add("StartAt", Util.toSqlFormattedDate(item.StartAt));
            dataDict.Add("EndAt", Util.toSqlFormattedDate(item.EndAt));
            dataDict.Add("EasyQty", item.EasyQty + "");
            dataDict.Add("HardQty", item.HardQty + "");
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}='{item.Id}'");
        }
    }
}
