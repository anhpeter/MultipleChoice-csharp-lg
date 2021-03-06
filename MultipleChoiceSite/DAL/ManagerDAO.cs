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
        public Manager getByCodeAndPassword(String id, String password)
        {
            String sqlStr = $"SELECT * from {tableName} WHERE Code='{id}' AND Password='{password}'";
            Manager item = null;
            SqlDataReader dr = dbHelper.execRead(sqlStr);
            if (dr.Read())
            {
                item = fromDR(dr);
            }
            dbHelper.closeConnection();
            return item;
        }

        public Manager getByCode(String code)
        {
            return this.getByField("Code", code);
        }
        public List<Manager> searchByKeyWord(String keyword)
        {
            String sqlStr = getAllSqlStr($"where FullName like '%{keyword}%'");
            return getAll(sqlStr);
        }

        // ADD
        public override int add(Manager item)
        {
            Dictionary<String, String> dataDict = new Dictionary<String, String>();
            dataDict.Add("Password", Util.md5("loveguitar"));
            dataDict.Add("Code", item.Code);
            dataDict.Add("FullName", item.FullName);
            dataDict.Add("Address", item.Address);
            dataDict.Add("DOB", Util.toSqlFormattedDate(item.DOB));
            dataDict.Add("PhoneNumber", item.PhoneNumber);
            dataDict.Add("Position", item.Position);
            return addWithDic(dataDict);
        }

        // UPDATE
        public override bool update(Manager item)
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
