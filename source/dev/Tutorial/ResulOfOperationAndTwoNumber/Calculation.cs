using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResulOfOperationAndTwoNumber
{
    public class Calculation
    {
        public int Calculate(int x, int y, OperatorEnum operation)
        {
            switch (operation)
            {
                case OperatorEnum.Addition:
                    return x + y;
                case OperatorEnum.Substraction:
                    return x - y;
                case OperatorEnum.Multiplication:
                    return x * y;
                case OperatorEnum.Division:
                    return x / y;
                default:
                    throw new Exception("Do not support this operation");
            }
        }
    }
}
