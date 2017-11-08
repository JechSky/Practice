using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SamSung : ProductFacther
    {
        public SamSung(string id, double price, string name, int inventory) : base(id, price, name, inventory)
        {
        }
    }
}
