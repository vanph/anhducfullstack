using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Recursive Function Example: To calculate the Fibonacci number of a specific term :\n");
            Console.Write("-------------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe Fibonacci of {number}th term  is {Fib(number)}");

            Console.Write("No Recursive Function");
            Console.WriteLine($"\nThe Fibonacci of {number}th term  is {Fib2(number)}");

            Console.ReadLine();
        }

        private static int Fib(int n)
        {
            if (n < 1)
            {
                throw new Exception("the given number cannot less than 1");
            }
            return n == 1 || n == 2 ? 1 : Fib(n - 1) + Fib(n - 2);
        }

        private static double Fib2(int n)
        {
            if (n < 1)
            {
                throw new Exception("the given number cannot less than 1");
            }

            var fi = (1 + Math.Sqrt(5)) * 1.0 / 2;

            var result = ((Math.Pow(fi, n) - Math.Pow(1 - fi, n)) * 1.0) / Math.Sqrt(5);

            return result;
        }
    }
}
