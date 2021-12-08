using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
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

        // FETCHS
        public List<StudentResult> getAll(Pagination p)
        {
            return getAll(applyPagination(getAllSqlStr(), p));
        }

        public List<StudentResult> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where stu.FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }

        protected override String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                SELECT sr.*, stu.Code AS StudentCode, stu.FullName AS StudentFullName, stu.Address AS StudentAddress, stu.DOB AS StudentDOB, stu.Major AS StudentMajor, ex.Name AS ExamName, sub.Name AS SubjectName
                FROM StudentResults AS sr 
                    INNER JOIN Students AS stu ON (sr.StudentId = stu.Id)
                    INNER JOIN Exams AS ex ON (sr.ExamId = ex.Id)
                    INNER JOIN Subjects AS sub ON (ex.SubjectId = sub.Id)
                    {0}
                ORDER BY sr.Id desc
                ", otherWhereStr);
            return sqlStr;
        }


        // ADD
        public int add(StudentResult item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentId", item.StudentId + "");
            dataDict.Add("ExamId", item.ExamId + "");
            dataDict.Add("Points", item.Points + "");
            return addWithDic(dataDict, true);
        }

        // UPDATE
        public bool update(StudentResult item)
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
