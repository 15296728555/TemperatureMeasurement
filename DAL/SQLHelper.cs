using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    ///  通用数据访问类
    /// </summary>
  public static  class SQLHelper
    {

        
       

        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();




        /// <summary>
        /// 执行增、删、改（insert/update/delete）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行多结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader objReader =
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return objReader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 执行返回数据集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd); //创建数据适配器对象
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds);  //使用数据适配器填充数据集
                return ds;  //返回数据集
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 启用事务执行多条SQL语句
        /// </summary>      
        /// <param name="sqlList">SQL语句列表</param>      
        /// <returns></returns>
        public static bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();   //开启事务
                foreach (string itemSql in sqlList)//循环提交SQL语句
                {
                    cmd.CommandText = itemSql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();  //提交事务(同时自动清除事务)
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                    cmd.Transaction.Rollback();//回滚事务(同时自动清除事务)
                throw new Exception("调用事务方法UpdateByTran(List<string> sqlList)时出现错误：" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction != null)
                    cmd.Transaction = null;
                conn.Close();
            }
        }
        /// <summary>
        /// 获取服务器的时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerTime()
        {
            return Convert.ToDateTime(GetSingleResult("select getdate()"));
        }


        #region 【1】通用增删改操作 （普通格式化SQL语句和带参数SQL语句）（正式使用）

        /// <summary>
        /// 执行通用的增、删、改操作
        /// </summary>
        /// <param name="cmdText">sql语句或存储过程名称</param>
        /// <param name="param">参数数组</param>
        /// <param name="isProcedure">是否是存储过程</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText, SqlParameter[] param = null, bool isProcedure = false)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            try
            {
                conn.Open();
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                if (isProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;//这个枚举的设置表示当前cmdText是存储过程名称
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //如果有必要可以在这个的记录日志....


                //注意：我们通用的数据访问类是“底层”地方方法，我们捕获到异常，必须还得告诉调用者具体的异常。
                string errorMsge = "调用ExecuteNonQuery方法发生异常，具体异常信息：" + ex.Message;

                // throw ex;  //可以直接把ex对象跑出去，也可以做二次封装

                throw new Exception(errorMsge);
            }
            finally   //表示前面不管是否发生异常，都会执行的代码段
            {
                conn.Close();
            }




            #endregion



        }


    }












}

