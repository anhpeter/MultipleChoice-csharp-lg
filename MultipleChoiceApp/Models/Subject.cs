using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp
{
    public class Subject
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public int TotalQuestion { get; set; }
        public int Duration { get; set; }
        public String Lecturer { get; set; }
        //
        public static Subject fromDR(SqlDataReader dr)
        {
            Subject item = new Subject()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Code = Util.getDrValue(dr, "Code"),
                Name = Util.getDrValue(dr, "Name"),
                Lecturer = Util.getDrValue(dr, "Lecturer"),
                TotalQuestion = Util.parseToInt(Util.getDrValue(dr, "TotalQuestion"), -1),
                Duration = Util.parseToInt(Util.getDrValue(dr, "Duration"), -1),
            };
            return item;
        }
        //
        public Dictionary<String, String> toDictionary()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", this.Id + "");
            dic.Add("Code", this.Code);
            dic.Add("Subject Name", Name);
            dic.Add("Lecturer", Lecturer);
            dic.Add("Total Question", TotalQuestion + "");
            dic.Add("Duration", Duration + "");
            return dic;
        }
        public static Subject fromDictionary(Dictionary<String, String> dic)
        {
            Subject item = new Subject()
            {
                Code = Util.getDicValue(dic, "Code"),
                Name = Util.getDicValue(dic, "Subject Name"),
                Lecturer = Util.getDicValue(dic, "Lecturer"),
                TotalQuestion = Util.parseToInt(Util.getDicValue(dic, "Total Question")),
                Duration = Util.parseToInt(Util.getDicValue(dic, "Duration")),
            };
            return item;
        }
        public static bool idDictionaryKeysValid(String[] inputKeys)
        {
            string[] keys = new string[] { "Code", "Subject Name", "Lecturer", "Total Question", "Duration"};
            return Util.isSubArray(keys, inputKeys);
        }
        public static List<Subject> genListByDicList(List<Dictionary<String, String>> dicList)
        {
            List<Subject> list = new List<Subject>();
            foreach (var dic in dicList)
            {
                Subject item = Subject.fromDictionary(dic);
                list.Add(item);
            }
            return list;
        }
    }
}
