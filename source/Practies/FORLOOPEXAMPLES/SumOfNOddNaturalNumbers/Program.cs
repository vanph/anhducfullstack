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
            
            Console.WriteLine("Display the sum of n odd natural number:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Input number of terms : ");

            var number = Convert.ToInt32(Console.ReadLine());

            var myCalculator = new MyCalculator();
            var sum = myCalculator.SumOfOddNumbers(number);

            Console.WriteLine($"The Sum of odd Natural Number upto {number} terms : {sum}");
            Console.ReadLine();
        }

       
    }
}
