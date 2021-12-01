using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    public class DataHelper
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
    }
}
