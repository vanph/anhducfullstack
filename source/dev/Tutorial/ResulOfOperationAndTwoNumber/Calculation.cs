using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResulOfOperationAndTwoNumber
{
    public class Calculation
    {
        public int Calculate(int x, int y, string operation)
        {
            switch (operation)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                default:
                    throw new Exception("Do not support this operation");
            }
        }
    }
}
