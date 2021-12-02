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
    class StudentDAO : BaseDAO<Student>
    {
        public StudentDAO() : base("Students")
        {
            this.primaryKey = "Id";
        }

        // IMPLEMENT ABSTRACTS
        protected override Student fromDR(SqlDataReader dr)
        {
            return Student.fromDR(dr);
        }

        // FETCHS
        public List<Student> getAll()
        {
            return getAll(getAllSqlStr());
        }
        public List<Student> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }

        private String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                    select * from {0} {1} order by Id desc
                ", tableName, otherWhereStr);
            return sqlStr;
        }

        // ADD
        public int add(Student item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Password", "loveguitar");
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("Major", item.Major);
            return addWithDic(dataDict);
        }

        // UPDATE
        public bool update(Student item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("Major", item.Major);
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}='{item.Id}'");
        }
    }
}
