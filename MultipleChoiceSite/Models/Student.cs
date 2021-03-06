using MultipleChoiceSite.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceSite.Models
{
    public class Student : User
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public DateTime DOB { get; set; }
        public String Major { get; set; }
        public int CreatedBy { get; set; }
        //
        public int ExamStatus { get; set; }
        public static Student fromDR(SqlDataReader dr)
        {
            Student item = new Student()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Code = Util.getDrValue(dr, "Code"),
                Password = Util.getDrValue(dr, "Password"),
                FullName = Util.getDrValue(dr, "FullName"),
                Address = Util.getDrValue(dr, "Address"),
                Major = Util.getDrValue(dr, "Major"),
                DOB = Convert.ToDateTime(Util.getDrValue(dr, "DOB")),
                CreatedBy = Util.parseToInt(Util.getDrValue(dr, "CreatedBy")),
                //
                ExamStatus = Util.parseToInt(Util.getDrValue(dr, "ExamStatus")),
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
            dic.Add("Major", this.Major);
            dic.Add("Password", this.Password);
            return dic;
        }
        public static Student fromDictionary(Dictionary<String, String> dic)
        {
            Student item = new Student()
            {
                Id = Util.parseToInt(Util.getDicValue(dic, "Id")),
                Code = Util.getDicValue(dic, "Code"),
                FullName = Util.getDicValue(dic, "Full Name"),
                Address = Util.getDicValue(dic, "Address"),
                DOB = Util.parseToDatetime(Util.getDicValue(dic, "Day Of Birth"), new DateTime(2000, 01,01)),
                Major = Util.getDicValue(dic, "Major"),
                Password = Util.getDicValue(dic, "Password"),
            };
            return item;
        }
        public static bool idDictionaryKeysValid(String[] inputKeys)
        {
            string[] keys = new string[] {"Code", "Full Name", "Address", "Day Of Birth", "Major", "Password"};
            return Util.isSubArray(keys, inputKeys);
        }
        public static List<Student> genListByDicList(List<Dictionary<String, String>> dicList)
        {
            List<Student> list = new List<Student>();
            foreach (var dic in dicList)
            {
                Student item = Student.fromDictionary(dic);
                list.Add(item);
            }
            return list;
        }
    }
}
