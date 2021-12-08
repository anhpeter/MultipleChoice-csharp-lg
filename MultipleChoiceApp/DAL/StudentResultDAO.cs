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

        // ADD
        public int add(StudentResult item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentId", item.StudentId + "");
            dataDict.Add("ExamId", item.ExamId + "");
            dataDict.Add("Points", item.Points + "");
            return addWithDic(dataDict);
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
