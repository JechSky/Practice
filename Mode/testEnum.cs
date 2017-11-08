using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    public enum testEnum
    {
        [Description("nromal描述")]
        normal=0,
        [Description("cal描述")]
        cal =1,
        [Description("rate描述")]
        rate =2
    }
}
