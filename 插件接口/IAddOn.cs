using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 插件接口
{
    public interface IAddOn
    {
        string funName { get; }
        string Excuteing();
    }
}
