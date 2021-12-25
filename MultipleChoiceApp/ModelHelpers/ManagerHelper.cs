using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.Manager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MultipleChoiceApp.ModelHelpers
{
    public class ManagerHelper
    {
        public static Manager fromDR(SqlDataReader dr)
        {
            Manager item = new Manager()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Code = Util.getDrValue(dr, "Code"),
                Password = Util.getDrValue(dr, "Password"),
                FullName = Util.getDrValue(dr, "FullName"),
                Address = Util.getDrValue(dr, "Address"),
                DOB = Convert.ToDateTime(Util.getDrValue(dr, "DOB")),
                PhoneNumber = Util.getDrValue(dr, "PhoneNumber"),
                Position = Util.getDrValue(dr, "Position"),
            };
            return item;
        }

        //
        public Dictionary<String, String> toDictionary(Manager manager)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", manager.Id + "");
            dic.Add("Code", manager.Code);
            dic.Add("Full Name", manager.FullName);
            dic.Add("Address", manager.Address);
            dic.Add("Day Of Birth", Util.toSqlFormattedDate(manager.DOB));
            dic.Add("Password", manager.Password);
            dic.Add("Phone Number", manager.PhoneNumber);
            dic.Add("Position", manager.Position);
            return dic;
        }
        public static Manager fromDictionary(Dictionary<String, String> dic)
        {
            Manager item = new Manager()
            {
                Id = Util.parseToInt(Util.getDicValue(dic, "Id")),
                Code = Util.getDicValue(dic, "Code"),
                FullName = Util.getDicValue(dic, "Full Name"),
                Address = Util.getDicValue(dic, "Address"),
                DOB = Util.parseToDatetime(Util.getDicValue(dic, "Day Of Birth"), new DateTime(2000, 01,01)),
                Password = Util.getDicValue(dic, "Password"),
                PhoneNumber = Util.getDicValue(dic, "Phone Number"),
                Position = Util.getDicValue(dic, "Position"),
            };
            return item;
        }
        public static bool idDictionaryKeysValid(String[] inputKeys)
        {
            string[] keys = new string[] {"Code", "Full Name", "Address", "Day Of Birth", "Phone Number", "Position", "Password"};
            return Util.isSubArray(keys, inputKeys);
        }
        public static List<Manager> genListByDicList(List<Dictionary<String, String>> dicList)
        {
            List<Manager> list = new List<Manager>();
            foreach (var dic in dicList)
            {
                Manager item = ManagerHelper.fromDictionary(dic);
                list.Add(item);
            }
            return list;
        }
    }
}
