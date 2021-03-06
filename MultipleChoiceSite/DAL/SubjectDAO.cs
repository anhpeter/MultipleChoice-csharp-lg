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
        public List<Subject> getAvailableForExam(DateTime date, int studentId)
        {
            String sqlStr = string.Format(@"
                select *
                from Subjects as s inner join Exams as e on (s.Id = e.SubjectId)
                where 
                    e.StartAt <= '{0}' and
                    e.EndAt >= '{0}' and
                    exists (
                        select 1
                        from StudentExam 
                        where StudentId = '{1}' and ExamId=e.Id
                    )
                order by s.Name
                ", date.ToString(), studentId);
            return getAll(sqlStr);
        }
        public override List<Subject> getAllForSelectData()
        {
            String sqlStr = $"select * from {tableName} order by Name asc";
            return getAll(sqlStr);
        }
        public List<Subject> getAll()
        {
            return getAll(getAllSqlStr());
        }
        public List<Subject> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where Name like '%{keyword}%'");
            return getAll(sqlStr);
        }

        // ADD
        public override int add(Subject item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("Name", item.Name);
            dataDict.Add("Lecturer", item.Lecturer + "");
            dataDict.Add("TotalQuestion", item.TotalQuestion + "");
            dataDict.Add("Duration", item.Duration + "");
            dataDict.Add("CreatedBy", item.CreatedBy + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public override bool update(Subject item)
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
