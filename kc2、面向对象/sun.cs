using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc2_面向对象
{
    class sun:father
    {
        public  override void dosth()
        {
            //base.dosth();
            Console.WriteLine("sun do");
        }

        public new void dosth1()
        {
            Console.WriteLine("sun do1");
        }

    }
}
