using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1、泛型

            #region 理论

            //泛型：就是类的一个参数（参数必须是一个类，不能是对象）也就是类的一个占位符参数。
            //为什么有泛型：实现算法重用（重用类的结构）。避免装箱拆箱。类型安全，编译时会自动检测参数类型。

            #endregion

            #region 自定义泛型类

            //fx<int> fx = new fx<int>();
            //fx.Add(1);
            //fx.Add(2);
            //for (int i = 0; i < fx.Count; i++)
            //{
            //    Console.WriteLine(fx[i].ToString());
            //}

            //MyTestG<int> mtg = new MyTestG<int>();
            //mtg.Add(1);
            //mtg.Add(2);
            //mtg.Add(3);
            //for (int i = 0; i < mtg.Count(); i++)
            //{
            //    Console.WriteLine(mtg[i].ToString());
            //}

            #endregion

            #region 自定义泛型字典

            //dictionary<int, int> dic = new dictionary<int, int>();
            //dic.Add(1, 1);
            //dic.Add(0, 2);
            //for (int i = 0; i < dic.Count; i++)
            //{
            //    Console.WriteLine(dic[i].ToString());
            //}

            //MyDictionary<string, string> mdic = new MyDictionary<string, string>();
            //mdic.Add("a", "d");
            //mdic.Add("q", "w");
            //foreach (var item in mdic.Keys())
            //{
            //    Console.WriteLine(mdic[item]);
            //} 

            #endregion

            #region ArrayList tolist 类型转换 ChangeType

            //ArrayList arrylist = new ArrayList();
            //arrylist.Add("11");
            //arrylist.Add(00);
            //arrylist.Add(123);
            //List<int> list = ToList1<int>(arrylist);
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrylist = new ArrayList();
            //arrylist.Add("123");
            //arrylist.Add("456");
            //arrylist.Add("000");
            //IList<int> ilist = ToList<int>(arrylist);
            //Console.WriteLine(ilist.Count.ToString());
            //for (int i = 0; i < ilist.Count; i++)
            //{
            //    Console.WriteLine(ilist[i].ToString());
            //}

            #endregion

            #endregion //1、泛型end


            #region 泛型反射查询数据库

            //string strSql = "select * from classes"; 
            ////string strSql = "select * from classes where id>@id";
            ////SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id",1)};
            //List<classes> list = CommonSqlHelper.getlist<classes>(strSql);
            //foreach (classes item in list)
            //{
            //    Console.WriteLine("name:{0} age:{1}", item.name, item.age);
            //}

            //string strSql = "select * from classes where id>@id";
            //SqlParameter para = new SqlParameter("@id", 1);
            //List<classes> list = CommonSqlHelper.GetList<classes>(strSql, para);
            //foreach (classes item in list)
            //{
            //    Console.WriteLine("name:{0},age:{1}",item.name,item.age);
            //}

            #endregion 


        } 

       static  List<T> ToList1<T>(ArrayList arr)
        {
            List<T> list = new List<T>();
            foreach (object item in arr)
            {
                T obj = (T)Convert.ChangeType(item, typeof(T));
                list.Add(obj);
            }
            return list;
        }

        static IList<T> ToList<T>(ArrayList arr)
        {
            List<T> list = new List<T>();
            foreach (object item in arr)
            {
                T obj = (T)Convert.ChangeType(item, typeof(T));
                list.Add(obj);
            }
            return list;
        }




    }
}
