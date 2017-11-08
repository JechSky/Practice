using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc2_面向对象
{
    class xiaohai : abserson
    {
        public override void Run()
        {
            Console.WriteLine("xiaohai run");
        }

        protected override void smile()
        {
            Console.WriteLine("xiaohai smile");
        }

        //public new void how()
        //{
        //    Console.WriteLine("xiaohai how");
        //}

    }
}
