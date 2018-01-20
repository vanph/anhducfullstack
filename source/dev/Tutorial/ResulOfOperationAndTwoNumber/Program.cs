using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResulOfOperationAndTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operation:");
            var operation = Console.ReadLine();

            Console.WriteLine("Input second number:");
            var y = Convert.ToInt32(Console.ReadLine());
            
            var allowedOperations = new string[] {"*", "-", "+"};
            if(allowedOperations.Contains(operation))
            {
                var calculation = new Calculation();
                var result = calculation.Calculate(x, y, operation);

                Console.WriteLine($"{x} {operation} {y} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid operator !");
            }
           

            Console.ReadLine();

        }

       
    }
}

