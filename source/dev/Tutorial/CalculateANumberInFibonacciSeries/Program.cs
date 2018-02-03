using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateANumberInFibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, c;
            Console.WriteLine("Enter the number of terms:");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fibonacci series\n");

            for (c = 1; c <= n; c++)
            {
                int result = FibonacciFunction(i);
                Console.Write(result + " ");
                i++;
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        public static int FibonacciFunction(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 1;
            }

            return FibonacciFunction(n - 1) + FibonacciFunction(n - 2);
        }
    }
}
