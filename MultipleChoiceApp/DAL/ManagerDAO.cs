﻿using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class ManagerDAO : BaseDAO<Manager>
    {
        public ManagerDAO() : base("Managers")
        {
            this.primaryKey = "Id";
        }

        // IMPLEMENT ABSTRACTS
        protected override Manager fromDR(SqlDataReader dr)
        {
            return Manager.fromDR(dr);
        }

        // FETCHS
        public List<Manager> getAll()
        {
            return getAll(getAllSqlStr());
        }
        public List<Manager> searchByKeyWord(String keyword)
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
        public int add(Manager item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("PhoneNumber", item.PhoneNumber);
            dataDict.Add("Position", item.Position);
            return addWithDic(dataDict);
        }

        // UPDATE
        public bool update(Manager item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("PhoneNumber", item.PhoneNumber);
            dataDict.Add("Position", item.Position);
            return base.updateWithDict(dataDict, $"WHERE {primaryKey}='{item.Id}'");
        }
    }
}