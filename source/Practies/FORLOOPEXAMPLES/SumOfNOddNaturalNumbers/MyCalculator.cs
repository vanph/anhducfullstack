using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNOddNaturalNumbers
{
   public class MyCalculator
    {
        public int SumOfOddNumbers(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += 2 * i - 1;
            }

            return sum;
        }
    }
}
