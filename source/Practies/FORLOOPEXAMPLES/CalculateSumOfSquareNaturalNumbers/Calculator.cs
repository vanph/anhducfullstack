using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumOfSquareNaturalNumbers
{
    public class Calculator
    {
        public int SumOfSquareNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i * i;
            }
            return sum;
        }
    }
}
