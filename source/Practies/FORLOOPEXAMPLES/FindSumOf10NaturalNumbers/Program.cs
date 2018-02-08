using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumOf10NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine($"Find the sum of first 10 natural numbers:");
            Console.WriteLine("----------------------------------------------");
            Console.Write("The first 10 natural number are :\n");
            for (var j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write($"{j} ");
            }
            Console.WriteLine($"\nThe Sum of 10 natural number is : {sum}" );
            Console.ReadLine();
        }
    }
}
