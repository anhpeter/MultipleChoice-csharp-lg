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
        //
        public List<Student> getStudentsNotInExam(int examId)
        {
            String sqlStr = string.Format(@"
                select *
                from Students 
                where not exists (
                    select 1
                    from StudentExam where StudentId = Id and ExamId = {0}
                )
            ", examId);
            return getAll(sqlStr);
        }

        public List<Student> getStudentInExam(int examId)
        {
            String sqlStr = string.Format(@"
                select 
                  stu.*, 
                  CASE WHEN stuRes.Id is NULL THEN 0 ELSE 1 END AS ExamStatus 
                from 
                  Students as stu 
                  left join StudentExam as stuEx on (stu.Id = stuEx.StudentId) 
                  left join StudentResults as stuRes on (
                    stuRes.StudentId = stuEx.StudentId 
                    and stuRes.ExamId = stuEx.ExamId
                  ) 
                where 
                  stuEx.ExamId = {0}

            ", examId);
            return getAll(sqlStr);
        }

        public int setStudentsForExam(List<int> studentIds, int examId)
        {
            // EMPTY STUDENTS IN EXAM
            String sqlStr = string.Format(@"
                delete from StudentExam where ExamId = {0}
            ", examId);
            dbHelper.execWrite(sqlStr);
            //
            List<Dictionary<String, String>> dics = new List<Dictionary<string, string>>();
            foreach (int id in studentIds)
            {
                Dictionary<String, String> dataDict = new Dictionary<String, String>();
                dataDict.Add("StudentId", id + "");
                dataDict.Add("ExamId", examId + "");
                dics.Add(dataDict);
            }
            if (dics.Count > 0)
            {
                return addWithDics(dics, "StudentExam");
            }
            return 0;
        }
        public int addStudentsToExam(List<int> studentIds, int examId)
        {
            List<Dictionary<String, String>> dics = new List<Dictionary<string, string>>();
            foreach (int id in studentIds)
            {
                Dictionary<String, String> dataDict = new Dictionary<String, String>();
                dataDict.Add("StudentId", id + "");
                dataDict.Add("ExamId", examId + "");
                dics.Add(dataDict);
            }
            if (dics.Count > 0)
            {
                return addWithDics(dics, "StudentExam");
            }
            return 0;
        }

        public int removeStudentsFromExam(List<int> studentIds, int examId)
        {
            String sqlStr = string.Format(@"
                delete from StudentExam
                where StudentId in ({0}) and ExamId = {1}
            ", string.Join(",", studentIds), examId);
            int affectedRows = dbHelper.execWrite(sqlStr);
            return affectedRows;

        }
        //


        public Student getByCodeAndPassword(String id, String password)
        {
            String sqlStr = $"SELECT * from {tableName} WHERE Code='{id}' AND Password='{password}'";
            Student item = null;
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = fromDR(dr);
            }
            dbHelper.closeConnection();
            return item;
        }


        public List<Student> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }
        public Student getByCode(String code)
        {
            return this.getByField("Code", code);
        }

        // ADD
        public override int add(Student item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Password", Util.md5("loveguitar"));
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("Major", item.Major);
            dataDict.Add("CreatedBy", item.CreatedBy + "");
            return addWithDic(dataDict);
        }

        // UPDATE
        public override bool update(Student item)
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
