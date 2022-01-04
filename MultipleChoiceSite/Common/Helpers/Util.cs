using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceSite.Common.Helpers
{
    public class Util
    {
        public static String getDicValue(Dictionary<String, String> dic, String key, String defaultVal = "")
        {
            try
            {
                return dic[key].ToString();
            }
            catch (Exception ex)
            {
                return defaultVal;
            }
        }
        public static String getDrValue(SqlDataReader dr, String field, String defaultVal = "")
        {
            try
            {
                return dr[field].ToString();
            }
            catch (Exception ex)
            {
                return defaultVal;
            }
        }

        public static Double parseToDouble(String stringToParse, double defaultValue = -1)
        {
            try
            {
                return Convert.ToDouble(stringToParse);
            }
            catch (Exception ex)
            {
                return defaultValue; //Use default value if parsing failed
            }
        }
        public static int parseToInt(String stringToParse, int defaultValue = -1)
        {
            try
            {
                return Convert.ToInt32(stringToParse);
            }
            catch (Exception ex)
            {
                return defaultValue; //Use default value if parsing failed
            }
        }
        public static DateTime parseToDatetime(String stringToParse, DateTime? defaultVal = null)
        {
            try
            {
                return Convert.ToDateTime(stringToParse);
            }
            catch (Exception ex)
            {
                return defaultVal ?? DateTime.Now; //Use default value if parsing failed
            }
        }

        public static String toSqlFormattedDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        public static String toExamFormattedDate(DateTime date)
        {
            return date.ToString("dd/MM/yyy HH:mm");
        }

        public static void log(String value)
        {
            Debug.WriteLine(value);
        }
        public static string md5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public static String strPad(String value, int length, String c)
        {
            if (value.Length >= length) return value;
            int leftLength = length - value.Length;
            return string.Concat(Enumerable.Repeat(c, leftLength)) + value;
        }

        public static bool isSubArray(string[] parent, string[] sub)
        {
            for (int i = 0; i < parent.Length; i++)
            {
                if (Array.IndexOf(sub, parent[i]) == -1) return false;
            }
            return true;
        }

        public static int getRandom(Random rnd, int min, int max)
        {
            return Convert.ToInt32(Math.Floor(rnd.Next(max - min + 1) + min * 1.0));
        }

    }

}
