using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operation oper = OperationFactory.CreateOperation("-");
            //oper.NumberA = 3;
            //oper.NumberB = 1;
            //Console.WriteLine(oper.GetResult());

            //Singleton sing1 = Singleton.GetInstance();
            //Singleton sing2 = Singleton.GetInstance();
            //if(sing1==sing2)
            //    Console.WriteLine("equals");

            Cat cat = new Cat();
            Mouse mouse1 = new Mouse("mouse1", cat);
            Mouse mouse2 = new Mouse("muse2", cat);
            Master master = new Master(cat);
            cat.Cry();


        }
    }
}
