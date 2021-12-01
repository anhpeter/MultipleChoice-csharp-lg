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

        // FETCHES
        public List<T> getAll()
        {
            List<T> list = new List<T>();
            try
            {
                String sqlStr = $"Select * from {tableName} order by Name asc";
                SqlDataReader dr = dbHelper.execRead(sqlStr);
                while (dr.Read())
                {
                    list.Add(fromDR(dr));
                }
                dbHelper.closeConnection();
                return list;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
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
