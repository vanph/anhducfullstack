using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FindSumOf10NaturalNumbers
{
    class Program
    {
        //method => void
        static void Main(string[] args)
        {
            var number = 5;//variable

            Console.WriteLine($"Find the sum of first {number} natural numbers:");
            Console.WriteLine("----------------------------------------------");
            Console.Write($"The first {number} natural number are :\n");

            var sum = SumOfFirstGivenNumbers(number);

            Console.WriteLine($"\nThe Sum of {number} natural number is : {sum}" );

            Console.WriteLine($"\nV2: The Sum of {number} natural number is : {SumOfFirstGivenNumbers2(number)}");

            Console.ReadLine();
        }


        //method => int || function
        private static int SumOfFirstGivenNumbers(int number)//number here is parameter of the function
        {
            var sum = 0; //variable : bien

            for ( int j = 1; j <= number; j++)//j is a veriable
            {
                sum = sum + j;
            }

            return sum;
        }

        private static int SumOfFirstGivenNumbers2(int n)
        {
            //sum = n(n+1)/2

            return n * (n + 1) / 2;

        }
    }
}
