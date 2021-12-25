using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    public class SubjectHelper
    {
        public static Dictionary<String, String> toDictionary(Subject item)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Id", item.Id + "");
            dic.Add("Code", item.Code);
            dic.Add("Subject Name", item.Name);
            dic.Add("Lecturer", item.Lecturer);
            dic.Add("Total Question", item.TotalQuestion + "");
            dic.Add("Duration", item.Duration + "");
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
                Subject item = SubjectHelper.fromDictionary(dic);
                list.Add(item);
            }
            return list;
        }
    }
}
