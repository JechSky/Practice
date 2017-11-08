using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc5_设计模式
{
    public class Operation
    {
        double numberA = 0;
        double numberB = 0;

        public double NumberA
        {
            get
            {
                return numberA;
            }

            set
            {
                numberA = value;
            }
        }

        public double NumberB
        {
            get
            {
                return numberB;
            }

            set
            {
                numberB = value;
            }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }
}
