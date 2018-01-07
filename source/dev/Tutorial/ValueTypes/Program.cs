using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"max of int:{int.MaxValue}");
            //Console.WriteLine($"min of int:{int.MinValue}");
            //Console.WriteLine($"default of int:{default(int)}");

            //Console.WriteLine($"max of decimal:{decimal.MaxValue}");
            //Console.WriteLine($"max of double:{double.MaxValue}");
            Console.WriteLine("Please input a number:");
            
            var sum = Sum(1000);

            Console.WriteLine(sum);

            Console.ReadLine();           
        }

        private static int Sum(int number)
        {
            var sum = 0;

            for (var i = 1; i <= number; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

    }
}
