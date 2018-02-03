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

            if (number >= 1)
            {
                Console.WriteLine($"\nRecursive Function: The Fibonacci of {number}th term  is {Fib(number)}");
                Console.WriteLine($"\nNo Recursive Function: The Fibonacci of {number}th term  is {Fib2(number)}");
            }
            else
            {
                Console.WriteLine("Please input a number greater than 0");
            }

            Console.ReadLine();
        }

        private static int Fib(int n)
        {
            if (n < 1)
            {
                throw new Exception("the given number cannot less than 1");
            }

            //Console.WriteLine($"Fib {n} = Fib {n-1} + Fib {n-2}");
            //if (n == 1 || n == 2)
            //{
            //    return 1;
            //}

            //return Fib(n - 1) + Fib(n - 2);

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
