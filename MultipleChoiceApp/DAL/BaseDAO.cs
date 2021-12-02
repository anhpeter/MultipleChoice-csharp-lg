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
        protected String primaryKey = "Id";
        protected String searchField = "Name";
        protected String tableName;
        public BaseDAO(String tableName)
        {
            this.tableName = tableName;
        }

        // ABSTRACT
        protected abstract T fromDR(SqlDataReader dr);

        // FETCHES

        public List<T> getAll(String sqlStr = null)
        {
            List<T> list = new List<T>();
            try
            {

                sqlStr = sqlStr != null ? sqlStr : $"Select * from {tableName}";
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
        public T getByPK(String value)
        {
            return getByField(primaryKey, value);
        }
        public T getByField(String field, String value)
        {
            T item = default(T);
            try
            {
                String sqlStr = $"Select * from {tableName} where {field}='{value}'";
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

        // ADD
        protected int addWithDic(Dictionary<String, String> dataDict, bool output = false)
        {
            try
            {
                // fields
                String[] keys = new List<string>(dataDict.Keys).ToArray();

                String updateFieldsStr = string.Join(" , ", keys);

                // values
                String[] values = new List<string>(dataDict.Values).ToArray();
                values = values.Select(v => $"N'{v}'").ToArray();
                String valuesStr = string.Join(" , ", values);

                String outputStr = output ? $"OUTPUT Inserted.{primaryKey}" : "";
                String sqlStr = $"INSERT INTO {tableName} ({updateFieldsStr}) {outputStr} VALUES ({valuesStr})";
                Debug.WriteLine(sqlStr);
                if (output) return dbHelper.execWriteScalar(sqlStr);
                return dbHelper.execWrite(sqlStr);
            }
            catch (Exception ex)
            {
                handleError(ex, "add");
                return -1;
            }

        }

        // UPDATES
        protected bool updateWithDict(Dictionary<String, String> dataDict, String whereClause)
        {
            try
            {
                String updateStr = "";
                foreach (KeyValuePair<String, String> kvp in dataDict)
                {
                    updateStr += $" {kvp.Key} = N'{kvp.Value}',";
                }
                updateStr = updateStr.Substring(0, updateStr.Length - 1);
                String sqlStr = $" UPDATE {tableName} SET {updateStr} {whereClause}";
                Debug.WriteLine(sqlStr);
                int affectedRows = dbHelper.execWrite(sqlStr);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                handleError(ex, "update");
                return false;
            }

        }
        public bool deleteByPK(String value)
        {
            return deleteByField(primaryKey, value);
        }

        public bool deleteByField(String field, String value)
        {
            try
            {
                String sqlStr = $"Delete from {tableName} where {field}='{value}'";
                int affectedRows = dbHelper.execWrite(sqlStr);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                handleError(ex, "delete-by-field");
                return false;
            }
        }

        // HELPER METHODS
        protected void handleError(Exception ex, String text)
        {
            Debug.WriteLine($"{tableName}.{text}:" + ex.Message);
        }

    }
}
