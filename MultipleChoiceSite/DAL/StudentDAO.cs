﻿using MultipleChoiceSite.Common.Helpers;
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
        public List<Student> getAll(Pagination p)
        {
            return getAll(applyPagination(getAllSqlStr(), p));
        }

        public List<Student> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }

        // ADD
        public override int add(Student item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Password",Util.md5("loveguitar"));
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("Major", item.Major);
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