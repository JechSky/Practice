﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    [AttributeUsage(AttributeTargets.Property)]
    public class testAttribute : Attribute
    {
        public bool isDisplay;
    }
}
