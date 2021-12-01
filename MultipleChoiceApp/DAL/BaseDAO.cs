﻿using MultipleChoiceApp.Common.Helpers;
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
            return getByField("Id", id.ToString());
        }

        // UPDATES
        protected bool updateWithDict(Dictionary<String, String> dataDict, String whereClause)
        {
            try
            {
                String updateStr = "";
                foreach (KeyValuePair<String, String> kvp in dataDict)
                {
                    updateStr += $" {kvp.Key} = '{kvp.Value}',";
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

        protected int addWithDic(Dictionary<String, String> dataDict, bool output = false)
        {
            try
            {
                // fields
                String[] keys = new List<string>(dataDict.Keys).ToArray();

                String updateFieldsStr = string.Join(" , ", keys);

                // values
                String[] values = new List<string>(dataDict.Values).ToArray();
                values = values.Select(v => $"'{v}'").ToArray();
                String valuesStr = string.Join(" , ", values);

                String outputStr = output ? "OUTPUT Inserted.Id" : "";
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
        public T getByField(String field, String value)
        {
            T item = default(T);
            try
            {
                String sqlStr = $"Select * from {tableName} where {field}={value}";
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

        public bool deleteById(int id)
        {
            return deleteByField("Id", id.ToString());
        }
        public bool deleteByCode(String code)
        {
            return deleteByField("Code", code);
        }
        public bool deleteByField(String field, String value)
        {
            try
            {
                String sqlStr = $"Delete from {tableName} where {field}={value}";
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
