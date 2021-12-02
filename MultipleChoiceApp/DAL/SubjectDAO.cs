using MultipleChoiceApp.Common.Models;
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
            this.primaryKey = "Code";
        }

        // IMPLEMENT ABSTRACTS
        protected override Subject fromDR(SqlDataReader dr)
        {
            return Subject.fromDR(dr);
        }

        // FETCHS
        public List<Subject> getAll()
        {
            return getAll(getAllSqlStr());
        }
        public List<Subject> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where Name like '%{keyword}%'");
            return getAll(sqlStr);
        }

        private String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                    select * from {0} {1} order by Name asc
                ", tableName, otherWhereStr);
            return sqlStr;
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
            return addWithDic(dataDict, true);
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
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}={item.Code}");
        }

        // DELETE

    }
}
