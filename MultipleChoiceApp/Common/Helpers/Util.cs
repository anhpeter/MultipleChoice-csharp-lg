using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    public class Util
    {
        public static String getDrValue(SqlDataReader dr, String field, String defaultVal = "")
        {
            try
            {
                return dr[field].ToString();
            }catch(Exception ex)
            {
                return defaultVal;
            }
        }

        public static int parseToInt(String stringToParse, int defaultValue)
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


    }

}
