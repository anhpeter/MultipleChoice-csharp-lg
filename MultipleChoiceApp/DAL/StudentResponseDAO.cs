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
        public List<StudentResponse> getAllByExamAndStudentId(int examId, int studentId)
        {
            String sqlStr = string.Format(@"
                select distinct ROW_NUMBER() OVER(order by stuRes.Id asc) as No, stuRes.Id, stuRes.QuestionId as QuestionId, CAST(q.Content as nvarchar(255)) as QuestionContent, 
                stuRes.AnswerOrder, q.CorrectAnswerNo, stuRes.AnswerNo as AnswerNo
                from StudentResponses as stuRes INNER JOIN StudentResults as sr on (stuRes.StudentResultId = sr.Id)
                inner join Questions as q  on (stuRes.QuestionId = q.Id)
                inner join Students as stu on (sr.StudentId = stu.Id)
                where sr.ExamId = {0}
                and stu.Id = {1}
                order by 2
            ", examId, studentId);
            return this.getAll(sqlStr);
        }

        // ADD
        public override int add(StudentResponse item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("StudentResultId", item.StudentResultId + "");
            dataDict.Add("QuestionId", item.QuestionId + "");
            dataDict.Add("AnswerOrder", item.getAnswerOrderString());
            dataDict.Add("AnswerNo", item.AnswerNO + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public override bool update(StudentResponse item)
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
