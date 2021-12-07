using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class SubjectDAO : BaseDAO<Subject>
    {
        public SubjectDAO() : base("Subjects")
        {
            this.primaryKey = "Id";
        }

        // IMPLEMENT ABSTRACTS
        protected override Subject fromDR(SqlDataReader dr)
        {
            return Subject.fromDR(dr);
        }

        // FETCHS
        public List<Subject> getAvailableForExam(DateTime date)
        {
            String sqlStr = string.Format(@"
                select *
                from Subjects as s inner join Exams as e on (s.Id = e.SubjectId)
                where 
                    e.StartAt <= '{0}' and
                    e.EndAt >= '{0}'
                order by s.Name", date.ToString());
            return getAll(sqlStr);
        }
        public List<Subject> getAllForSelectData()
        {
            String sqlStr = $"select * from {tableName} order by Name desc";
            return getAll(sqlStr);
        }
        public List<Subject> getAll(Pagination p)
        {
            return getAll(applyPagination(getAllSqlStr(), p));
        }
        public List<Subject> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where Name like '%{keyword}%'");
            return getAll(sqlStr);
        }

        // ADD
        public int add(Subject item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("Name", item.Name);
            dataDict.Add("Lecturer", item.Lecturer + "");
            dataDict.Add("TotalQuestion", item.TotalQuestion + "");
            dataDict.Add("Duration", item.Duration + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public bool update(Subject item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("Name", item.Name);
            dataDict.Add("Lecturer", item.Lecturer + "");
            dataDict.Add("TotalQuestion", item.TotalQuestion + "");
            dataDict.Add("Duration", item.Duration + "");
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}='{item.Id}'");
        }

        // DELETE

    }
}
