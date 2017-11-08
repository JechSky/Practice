using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc5_设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂

            //Operation oper;
            //oper = OperationFactory.CreateOperate("+");
            //oper.NumberA = 1;
            //oper.NumberB = 3;
            //double result = oper.GetResult();
            //Console.WriteLine(result); 

            #endregion

            #region 单例

            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();
            //if(s1==s2)
            //{
            //    Console.WriteLine("xt");
            //} 

            #endregion

            #region 观察者

            //Cat cat = new Cat();
            //Master master = new Master(cat);
            //Mouse mouse1 = new Mouse("mouse1", cat);
            //Mouse mouse2 = new Mouse("mouse2", cat);
            //cat.Cry(); 

            #endregion

        }


    }
}
