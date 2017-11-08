using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    class CalMN : CallFather
    {
        double M { get; set; }
        double N { get; set; }

        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }

        public override double GetTotalMoney(double realMoney)
        {
            if (realMoney >= this.M)
            {
                return realMoney - (double)(realMoney / this.M) * this.N;
            }
            else
                return realMoney;
        }
    }
}
