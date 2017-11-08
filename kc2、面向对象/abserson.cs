using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc2_面向对象
{
    abstract class abserson : interfaceRun
    {
        static string name;

        public static void Hello()
        {
            Console.WriteLine("hello");
        }

        public void how()
        {
            Console.WriteLine("abserson how");
        }

        protected abstract void smile();

        public abstract void Run();

        //public void Run()
        //{
        //    Console.WriteLine("absperson run");
        //}

    }
}
