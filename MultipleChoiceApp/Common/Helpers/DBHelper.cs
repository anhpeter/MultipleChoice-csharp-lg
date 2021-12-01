using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    abstract class DBHelper
    {
        String conStr = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        SqlConnection con;

        private SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(conStr);
            return con;
        }

        public SqlDataReader read(String sql)
        {
            try
            {
                con = getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                con.Close();
                return dr;
                //
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public int execWrite(String sql)
        {
            try
            {
                con = getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                int result = com.ExecuteNonQuery();
                con.Close();
                return result;
                //
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }

        public bool closeConnection()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        con.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
            return false;
        }
    }
}
