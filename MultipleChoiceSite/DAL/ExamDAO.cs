using MultipleChoiceSite.Common.Helpers;
using MultipleChoiceSite.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceSite.DAL
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
            ", tableName, startStr, endStr, subjectId);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            bool hasItems = dr.HasRows;
            return !hasItems;
        }

        // FETCHS
        public List<Exam> getAllForSelectData()
        {
            String sqlStr = $"select * from {tableName} order by Id desc";
            return getAll(sqlStr);
        }
        public Exam getExamReportById(int id)
        {
            Exam item = null;
            String sqlStr = string.Format(@"
                select ex.*, sub.Name as SubjectName, sub.TotalQuestion, sub.Duration, sub.Lecturer
                from Exams as ex inner join Subjects as sub on (ex.SubjectId = sub.Id)
                where (ex.Id = {0})
            ", id);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = Exam.fromDR(dr);
            }
            dbHelper.closeConnection();
            return item;
        }
        public ExamOverview getExamOverviewById(int id)
        {
            ExamOverview item = null;
            String sqlStr = string.Format(@"
                SELECT COUNT(sr.StudentId) as TakenStudentCount, AVG(sr.Points) as AveragePoints,
                sub.Duration as Duration, 	sub.TotalQuestion as TotalQuestion
                FROM Exams AS ex INNER JOIN Subjects AS sub ON (ex.SubjectId = sub.Id) LEFT JOIN StudentResults AS sr ON (ex.Id = sr.ExamId)
                WHERE ex.Id = {0}
                GROUP BY sr.ExamId, sub.TotalQuestion, sub.Duration
            ", id);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = ExamOverview.fromDR(dr);
            }
            dbHelper.closeConnection();
            return item;
        }
        public List<Exam> getAllForReport()
        {
            String sqlStr = string.Format(@"
                SELECT ex.Id, ex.Name, ex.StartAt, ex.EndAt,  COUNT(sr.StudentId) as StudentCount
                FROM Exams AS ex LEFT JOIN StudentResults AS sr ON (ex.Id = sr.ExamId)
                GROUP BY ex.Id, ex.Name,ex.StartAt, ex.EndAt
                ORDER BY ex.Id desc");
            return base.getAll(sqlStr);
        }
        public Exam getAvailableBySubjectId(int subjectId, DateTime d)
        {
            Exam item = null;
            String sqlStr = string.Format(@"
                select *
                from Exams as e inner join Subjects as s on (s.Id = e.SubjectId)
                where 
                    s.Id = '{0}' and
                    e.StartAt <= '{1}' and
                    e.EndAt >= '{1}'
                ", subjectId + "", d.ToString());
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
            dataDict.Add("CreatedBy", item.CreatedBy + "");
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
