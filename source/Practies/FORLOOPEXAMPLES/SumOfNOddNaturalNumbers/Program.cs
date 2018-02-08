using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNOddNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine($"Display the sum of n odd natural number:");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The odd numbers are :");
            for (int i = 1; i <= n; i++)
            {
                //Console.Write("{0} ", 2 * i - 1);
                Console.WriteLine(2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"The Sum of odd Natural Number upto {n} terms : {sum}",n,sum);
            Console.ReadLine();
        }
    }
}
