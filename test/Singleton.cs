using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Singleton
    {
        static Singleton singletonObj;
        static readonly object syncRoot = new object();
        Singleton() { }
        public static Singleton GetInstance()
        {
            if(singletonObj==null)
            {
                lock(syncRoot)
                {
                    if(singletonObj==null)
                    {
                        singletonObj = new Singleton();
                    }
                }
            }
            return singletonObj;

        }

    }
}
