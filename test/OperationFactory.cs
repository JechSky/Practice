using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operation)
        {
            Operation oper = null;

            switch (operation)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                    break;
                case "/":
                    oper = new OperaationDiv();
                    break;
                default:
                    break;
            }
            return oper;

        }

    }
}
