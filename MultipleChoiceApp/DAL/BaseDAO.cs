using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    abstract class BaseDAO<T>
    {
        protected DBHelper dbHelper = new DBHelper();

        protected String tableName;
        public BaseDAO(String tableName)
        {
            this.tableName = tableName;
        }

        // abstract
        protected abstract T fromDR(SqlDataReader dr);

        public T getById(int id)
        {
            T item = default(T);
            try
            {
                String sqlStr = $"Select * from {tableName} where Id={id}";
                SqlDataReader dr = dbHelper.execRead(sqlStr);
                if (dr.Read())
                {
                    item = fromDR(dr);
                }
                dbHelper.closeConnection();
                return item;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"get-by-id:{ex.Message}");
                return default(T);
            }
        }

        public T getByCode(String code)
        {
            T item = default(T);
            try
            {
                String sqlStr = $"Select * from {tableName} where Code={code}";
                SqlDataReader dr = dbHelper.execRead(sqlStr);
                if (dr.Read())
                {
                    item = fromDR(dr);
                }
                dbHelper.closeConnection();
                return item;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"get-by-code:{ex.Message}");
                return default(T);
            }
        }
    }
}
