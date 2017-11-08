using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 插件接口;

namespace 插件
{
    public class AddOnStrToUp : IAddOn
    {
        public string funName
        {
            get
            {
                return "ToUp";
            }
             
        }

        public string Excuteing()
        {
            return "Excuteing";
        }

        public string WithPara(string name)
        {
            return "withpara " + name;
        }

    }
}
