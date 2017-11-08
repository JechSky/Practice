using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc5_设计模式
{
    public class OperationSub:Operation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }
}
