using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    public class CommonSqlHelper
    {
        static string strCon = "server=.;database=test;uid=sa;pwd=123456";

        public static List<T> getlist<T> (string sql,params SqlParameter[] paras)
        {
            List<T> list = new List<T>();
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        T model = (T)Activator.CreateInstance(typeof(T));
                        PropertyInfo[] pros = typeof(T).GetProperties();
                        foreach (PropertyInfo pro in pros)
                        {
                            pro.SetValue(model, item[pro.Name], null);
                        }
                        list.Add(model);
                    }
                }
                return list;

            }
            return list;
        }

        public static List<T> GetList2<T>(string sql, params SqlParameter[] paras)
        {
            List<T> list = new List<T>();
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        T model = (T)Activator.CreateInstance(typeof(T));
                        PropertyInfo[] pros = typeof(T).GetProperties();
                        foreach (PropertyInfo item in pros)
                        {
                            item.SetValue(model, dr[item.Name], null);
                        }
                        list.Add(model);
                    }
                    return list;
                }

            }

            return list;
        }

        public static List<T> GetList1<T>(string strSql,params SqlParameter[] paras)
        {
            List<T> list = new List<T>();
            using (SqlConnection conn=new SqlConnection (strCon))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.SelectCommand.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        T model = (T)Activator.CreateInstance(typeof(T));
                        PropertyInfo[] pros = typeof(T).GetProperties();
                        foreach (PropertyInfo pro in pros)
                        {
                            string proName = pro.Name;
                            pro.SetValue(model, dr[proName], null);
                        }
                        list.Add(model);
                    }
                    return list;
                }
            }
            return list;

        }

        public static List<T> GetList<T>(string strSql,params SqlParameter[] paras)
        {
            List<T> list = new List<T>();
            using (SqlConnection conn=new SqlConnection(strCon))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.SelectCommand.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //Type modelType = typeof(T);
                        T model = (T)Activator.CreateInstance(typeof(T));
                        PropertyInfo[] pros = typeof(T).GetProperties();
                        foreach (PropertyInfo pro in pros)
                        {
                            string proName = pro.Name;
                            pro.SetValue(model, dr[proName], null);
                        }
                        list.Add(model);
                    }
                    return list;
                }

            }
            return list;

        }

    }


}
