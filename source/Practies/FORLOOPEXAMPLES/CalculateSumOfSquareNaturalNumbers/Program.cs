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
            
            Console.WriteLine("Calculate n terms of square natural number and their sum:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            var calculate = new Calculator();
            var sum = calculate.SumOfSquareNumber(n);

            Console.WriteLine($"\nThe Sum of Square Natural Number upto {n} terms = {sum}");
            Console.ReadLine();
        }
    }
}
