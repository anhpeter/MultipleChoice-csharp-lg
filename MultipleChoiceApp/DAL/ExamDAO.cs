using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Models;
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

        // FETCHS
        public List<Exam> getAll()
        {
            return getAll(getAllSqlStr());
        }
        public List<Exam> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where e.Name like '%{keyword}%'");
            return getAll(sqlStr);
        }

        private String getAllSqlStr(String otherWhereStr = "")
        {
            //String sqlStr = String.Format(@"
            //        select * from {0} {1} order by Id desc
            //    ", tableName, otherWhereStr);
            //return sqlStr;
            String sqlStr = String.Format(@"
                    SELECT DISTINCT e.*, s.Code as SubjectCode, s.TotalQuestion as TotalQuestion
                    FROM Exams as e
                        INNER JOIN Subjects as s ON (e.SubjectId = s.Id)
                    ORDER BY e.Id DESC;
                ", otherWhereStr);
            return sqlStr;
        }

        // ADD
        public int add(Exam item)
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
        public bool update(Exam item)
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
