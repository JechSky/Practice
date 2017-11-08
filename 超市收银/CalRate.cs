using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    class CalRate : CallFather
    {
        double Rate { get; set; }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }

        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * Rate;
        }
    }
}
