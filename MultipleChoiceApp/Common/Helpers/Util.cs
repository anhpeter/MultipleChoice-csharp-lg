using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
