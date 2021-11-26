using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using utils.Service;

namespace utils.Service
{
    class DBService
    {
        private string ConStr;
        private static DBService _m_instance = null;
        public static DBService getInstance(string dbStr)
        {
            if (_m_instance == null)
            {
                _m_instance = new DBService(dbStr);
            }
            return _m_instance;
        }
        /// <summary>
        /// 数据库服务类
        /// </summary>
        /// <param name="dbStr"></param>
        private DBService(string dbStr)
        {
            ConStr = ConfigurationManager.ConnectionStrings[dbStr].ConnectionString;
        }

        /// <summary>
        /// 根据Sql语句获取结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSetBySql(string sql, SqlParameter[] para = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                using (SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon))
                {
                    if (para != null)
                    {
                        sqlda.SelectCommand.Parameters.AddRange(para);
                    }
                    DataSet ds = new DataSet();
                    sqlda.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// 根据Sql语句获取结果表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTableBySql(string sql, SqlParameter[] para=null)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                try
                {
                    using (SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon))
                    {
                        if (para != null)
                        {
                            sqlda.SelectCommand.Parameters.AddRange(para);
                        }
                        DataSet ds = new DataSet();
                        sqlda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            return ds.Tables[0];
                        }
                        else
                        {
                            return new DataTable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.ToString();
                    return new DataTable();
                }
            }
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns>生效数据条数</returns>
        public int ExecuteSql(string sql, SqlParameter[] para = null)
        {
            int effectCount = 0;
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                try
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandTimeout = 300;
                        if (para != null)
                        {
                            cmd.Parameters.AddRange(para);
                        }
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlcon;

                        effectCount = cmd.ExecuteNonQuery();
                    }
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    string msg = ex.ToString();
                    return -1;
                }
            }
            return effectCount;
        }
    }
}
