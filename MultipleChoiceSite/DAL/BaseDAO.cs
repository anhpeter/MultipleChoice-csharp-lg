using MultipleChoiceSite.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceSite.DAL
{
    public abstract class BaseDAO<T>
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

        public abstract int add(T item);

        public abstract bool update(T item);

        // COUNT
        public int countAll()
        {
            String sqlStr = $"SELECT COUNT(*) FROM {tableName}";
            return count(sqlStr);
        }
        public int count(String sqlStr)
        {
            int result = dbHelper.execWriteScalar(sqlStr);
            //int result = -1;
            //if (dr.Read())
            //{
            //    result = 
            //}
            //dbHelper.closeConnection();
            return result;
        }

        // FETCHES
        public virtual List<T> getAllForSelectData()
        {
            String sqlStr = $"select * from {tableName} order by {primaryKey} desc";
            return getAll(sqlStr);
        }


        public List<T> getAll(int itemsPerPage, int currentPage)
        {
            return getAll(applyPagination(getAllSqlStr(), itemsPerPage, currentPage));
        }

        public List<T> getAll(String sqlStr = null)
        {
            List<T> list = new List<T>();
            try
            {
                sqlStr = sqlStr != null ? sqlStr : getAllSqlStr();
                Util.log(sqlStr);
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
        protected virtual String getAllSqlStr(String otherWhereStr = "")
        {
            String sqlStr = String.Format(@"
                    select * from {0} {1} order by Id desc
                ", tableName, otherWhereStr);
            return sqlStr;
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
        protected int addWithDics(List<Dictionary<String, String>> dataDicts, String tableName = null)
        {
            tableName = tableName == null ? this.tableName : tableName;
            String sqlStr = genInsertSqlStr(dataDicts, tableName);
            //foreach (var key in dataDict.Keys.ToArray())
            //{
            //    String value = standardizeValue(dataDict[key]);
            //    sqlStr = sqlStr.Replace($"@{key}", $"N'{value}'");
            //}
            Debug.WriteLine(sqlStr);
            SqlCommand com = new SqlCommand(sqlStr);
            //addParamValueToCom(dataDict, com);
            return dbHelper.execWrite(com);
        }
        protected int addWithDic(Dictionary<String, String> dataDict, bool output = false)
        {
            String sqlStr = genInsertSqlStr(dataDict, output);
            foreach (var key in dataDict.Keys.ToArray())
            {
                String value = standardizeValue(dataDict[key]);
                sqlStr = sqlStr.Replace($"@{key}", $"N'{value}'");
            }
            Debug.WriteLine(sqlStr);
            SqlCommand com = new SqlCommand(sqlStr);
            //addParamValueToCom(dataDict, com);
            if (output) return dbHelper.execWriteScalar(com);
            return dbHelper.execWrite(com);
        }


        // UPDATES
        protected bool updateWithDict(Dictionary<String, String> dataDict, String whereClause)
        {
            String sqlStr = genUpdateSqlStr(dataDict, whereClause);
            foreach (var key in dataDict.Keys.ToArray())
            {
                String value = standardizeValue(dataDict[key]);
                sqlStr = sqlStr.Replace($"@{key}", $"N'{value}'");
            }
            Debug.WriteLine(sqlStr);
            SqlCommand com = new SqlCommand(sqlStr);
            //addParamValueToCom(dataDict, com);
            int affectedRows = dbHelper.execWrite(com);
            return affectedRows > 0;
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

        private void addParamValueToCom(Dictionary<String, String> dataDict, SqlCommand com)
        {
            foreach (var key in dataDict.Keys.ToArray())
            {
                com.Parameters.Add(new SqlParameter($"@{key}", "N" + dataDict[key]));
            }
        }
        private String genInsertSqlStr(List<Dictionary<String, String>> dataDicts, String tableName)
        {
            // fields
            String[] keys = new List<string>(dataDicts[0].Keys).ToArray();
            String updateFieldsStr = string.Join(" , ", keys);
            // values
            List<String> valueList = new List<string>();
            //String[] valueParams = keys.Select(k => $"@{k}").ToArray();
            foreach (var dic in dataDicts)
            {
                String[] valueParams = dic.Values.Select(v => $"N'{v}'").ToArray();
                String valueParamsStr = string.Join(" , ", valueParams);
                valueList.Add($"({valueParamsStr})");
            }
            String valueString = string.Join(",", valueList);
            String sqlStr = $"INSERT INTO {tableName} ({updateFieldsStr}) VALUES {valueString}";
            return sqlStr;
        }
        private String genInsertSqlStr(Dictionary<String, String> dataDict, bool output = false)
        {
            String[] keys = new List<string>(dataDict.Keys).ToArray();
            String updateFieldsStr = string.Join(" , ", keys);
            String[] valueParams = keys.Select(k => $"@{k}").ToArray();
            String valueParamsStr = string.Join(" , ", valueParams);
            String outputStr = output ? $"OUTPUT Inserted.{primaryKey}" : "";
            String sqlStr = $"INSERT INTO {tableName} ({updateFieldsStr}) {outputStr} VALUES ({valueParamsStr})";
            return sqlStr;
        }
        private String genUpdateSqlStr(Dictionary<String, String> dataDict, String whereClause)
        {

            String updateStr = "";
            foreach (KeyValuePair<String, String> kvp in dataDict)
            {
                updateStr += $" {kvp.Key} = @{kvp.Key},";
            }
            updateStr = updateStr.Substring(0, updateStr.Length - 1);
            String sqlStr = $" UPDATE {tableName} SET {updateStr} {whereClause}";
            return sqlStr;
        }
        private String standardizeValue(String value)
        {
            if (String.IsNullOrEmpty(value)) return "";
            return value.Replace("'", "''");
        }

        protected String applyPagination(String sqlStr, int itemsPerPage, int currentPage)
        {
            int offset = (currentPage - 1) * itemsPerPage;
            int limit = itemsPerPage;
            sqlStr += $" OFFSET {offset} ROWS FETCH NEXT {limit} ROWS ONLY";
            return sqlStr;
        }
    }
}
