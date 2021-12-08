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
    class StudentResponseDAO : BaseDAO<StudentResponse>
    {
        public StudentResponseDAO() : base("StudentResponses")
        {
        }

        // IMPLEMENT ABSTRACTS
        protected override StudentResponse fromDR(SqlDataReader dr)
        {
            return StudentResponse.fromDR(dr);
        }

        // FETCHS
        public List<StudentResponse> getAll(Pagination p)
        {
            return getAll(applyPagination(getAllSqlStr(), p));
        }

        // ADD
        public int add(StudentResponse item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentResultId", item.StudentResultId + "");
            dataDict.Add("QuestionId", item.QuestionId + "");
            dataDict.Add("AnswerOrder", item.getAnswerOrderString());
            dataDict.Add("AnswerNo", item.AnswerNO + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public bool update(StudentResponse item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("AnswerOrder", item.getAnswerOrderString());
            dataDict.Add("AnswerNo", item.AnswerNO + "");
            return base.updateWithDict(dataDict, $"WHERE StudentResultId='{item.StudentResultId}' AND QuestionId='{item.QuestionId}'");
        }

        public bool addMany(List<StudentResponse> list, int studentResultId)
        {
            bool result = true;
            foreach (StudentResponse item in list)
            {
                item.StudentResultId = studentResultId;
                if (add(item) < 1) result = false;
            }
            return result;
        }
    }
}
