﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    class Banana : ProductFather
    {
        public Banana(string id, string name, double price, int inventory) : base(id, name, price, inventory)
        {
        }
    }
}
