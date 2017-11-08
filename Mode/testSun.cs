using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    public class testSun:testFather,IRun
    {
        public string name { get; set; }

        public string Shout()
        {
            return "shout";
        }

        public string Shout(string nameObj)
        {
            return name + " 参数：" + nameObj;
        }

        public string Shout(string nameObj,int intObj)
        {
            return string.Format("{0} 参数1：{1} 参数2：{2}", name, nameObj, intObj);
        }

        private string priFunc()
        {
            return "私有方法";
        }

    }
}
