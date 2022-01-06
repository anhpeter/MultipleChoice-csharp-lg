using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApi.Common.Helpers
{
    public class DBHelper
    {
        String conStr = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        SqlConnection con;


        // EXECS
        public SqlDataReader execRead(String sql)
        {
            try
            {
                con = getConnection();
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                return dr;
                //
            }
            catch (Exception ex)
            {
                closeConnection();
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public int execWriteScalar(String sql)
        {
            SqlCommand com = new SqlCommand(sql);
            return execWriteScalar(com);
        }
        public int execWriteScalar(SqlCommand com)
        {
            try
            {
                con = getConnection();
                con.Open();
                com.Connection = con;
                int result = (int)com.ExecuteScalar();
                closeConnection();
                return result;
                //
            }
            catch (Exception ex)
            {
                closeConnection();
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }

        public int execWrite(String sql)
        {
            SqlCommand com = new SqlCommand(sql);
            return execWrite(com);
        }

        public int execWrite(SqlCommand com)
        {
            try
            {
                con = getConnection();
                con.Open();
                com.Connection = con;
                int result = com.ExecuteNonQuery();
                closeConnection();
                return result;
                //
            }
            catch (Exception ex)
            {
                closeConnection();
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }

        // HEPER METHODS
        public SqlConnection getConnection()
        {
            con = new SqlConnection(conStr);
            return con;
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
                        closeConnection();
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
            return false;
        }
    }
}
