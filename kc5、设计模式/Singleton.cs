using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc5_设计模式
{
    class Singleton
    {
        static Singleton instance;
        static readonly object syncRoot = new object();

        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            if(instance==null)
            {
                lock(syncRoot)
                {
                    if(instance==null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

    }
}
