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
    class StudentResultDAO : BaseDAO<StudentResult>
    {
        public StudentResultDAO() : base("StudentResults")
        {
            primaryKey = "Id";
        }

        // IMPLEMENT ABSTRACTS
        protected override StudentResult fromDR(SqlDataReader dr)
        {
            return StudentResult.fromDR(dr);
        }

        // CHECK
        public bool isExamTaken(int studentId, int examId)
        {
            String sqlStr = string.Format(
                @"SELECT * FROM {0}
                WHERE StudentId = {1} AND ExamId = {2}", tableName, studentId, examId);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            bool result = dr.HasRows;
            dbHelper.closeConnection();
            return result;
        }

        // FETCHS
        public List<StudentResult> getAllByExamId(int id)
        {
            String sqlStr = string.Format(@"
                SELECT ROW_NUMBER() OVER(ORDER BY sr.Points desc) AS Rank, 
								stu.Major as StudentMajor,
								stu.Id as StudentId, stu.Code as StudentCode, stu.FullName as StudentFullName, ISNULL(unanswered.Unanswered, 0) as UnansweredCount, sr.Points 
                FROM Students AS stu INNER JOIN StudentResults AS sr ON (stu.Id = sr.StudentId) LEFT JOIN (
                    SELECT stuRes.StudentResultId, COUNT(AnswerNo) as Unanswered
                    FROM StudentResponses AS stuRes
                    WHERE stuRes.AnswerNo = 0
                    GROUP BY StudentResultId
                ) as unanswered ON (sr.Id = unanswered.StudentResultId)
                WHERE sr.ExamId = {0}
                ORDER BY sr.Points desc
", id);
            return getAll(sqlStr);
        }
        public List<StudentResult> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where stu.FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }

        protected override String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                SELECT sr.*, stu.Code AS StudentCode, stu.FullName AS StudentFullName, stu.Address AS StudentAddress, stu.DOB AS StudentDOB,  stu.Major AS StudentMajor, ex.Name AS ExamName, sub.Name AS SubjectName
                FROM StudentResults AS sr 
                    INNER JOIN Students AS stu ON (sr.StudentId = stu.Id)
                    INNER JOIN Exams AS ex ON (sr.ExamId = ex.Id)
                    INNER JOIN Subjects AS sub ON (ex.SubjectId = sub.Id)
                    {0}
                ORDER BY sr.Id desc
                ", otherWhereStr);
            return sqlStr;
        }

        public StudentResult getDetailByExamAndStudentId(int examId, int studentId)
        {
            StudentResult item = null;
            String sqlStr = string.Format(@"
                SELECT  stu.Code AS StudentCode, stu.FullName AS StudentFullName, 
                        stu.Major AS StudentMajor, sr.Points
                FROM StudentResults AS sr 
                    INNER JOIN Students AS stu ON (sr.StudentId = stu.Id)
                    INNER JOIN Exams AS ex ON (sr.ExamId = ex.Id)
                    INNER JOIN Subjects AS sub ON (ex.SubjectId = sub.Id)
                 where ex.Id = {0}
				 and stu.Id = {1}
            ", examId, studentId);
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = StudentResult.fromDR(dr);
            }
            dbHelper.closeConnection();
            return item;
        }

        // ADD
        public override int add(StudentResult item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentId", item.StudentId + "");
            dataDict.Add("ExamId", item.ExamId + "");
            dataDict.Add("Points", item.Points + "");
            return addWithDic(dataDict, true);
        }

        // UPDATE
        public override bool update(StudentResult item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentId", item.StudentId + "");
            dataDict.Add("ExamId", item.ExamId + "");
            dataDict.Add("Points", item.Points + "");
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}='{item.Id}'");
        }

        public bool addMany(List<StudentResult> list)
        {
            bool result = true;
            foreach (StudentResult item in list)
            {
                if (add(item) < 1) result = false;
            }
            return result;
        }
    }
}
