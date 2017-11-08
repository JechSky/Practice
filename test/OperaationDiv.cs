using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class OperaationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0.0;
            if (NumberB == 0)
                throw new Exception("除数不能为0");
            else
                result = NumberA / NumberB;
            return result;
        }
    }
}
