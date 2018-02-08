using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumOfSquareNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine($"Calculate n terms of square natural number and their sum:");
            Console.WriteLine($"-----------------------------------------------------------");
            Console.WriteLine($"Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The square natural upto {0} terms are :", n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}  ", i * i);
                sum += i * i;
            }
            Console.WriteLine("\nThe Sum of Square Natural Number upto {0} terms = {1}", n, sum);
            Console.ReadLine();
        }
    }
}
