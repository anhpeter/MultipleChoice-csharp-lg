using MultipleChoiceSite.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceSite.Models
{
    public class Manager:User
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public DateTime DOB { get; set; }
        public String PhoneNumber { get; set; }
        public String Position { get; set; }
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
        public Dictionary<String, String> toDictionary()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", this.Id + "");
            dic.Add("Code", this.Code);
            dic.Add("Full Name", this.FullName);
            dic.Add("Address", this.Address);
            dic.Add("Day Of Birth", Util.toSqlFormattedDate(this.DOB));
            dic.Add("Password", this.Password);
            dic.Add("Phone Number", this.PhoneNumber);
            dic.Add("Position", this.Position);
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
                Manager item = Manager.fromDictionary(dic);
                list.Add(item);
            }
            return list;
        }
    }
}
