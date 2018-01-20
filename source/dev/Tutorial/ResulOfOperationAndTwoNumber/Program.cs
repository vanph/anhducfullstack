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

            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine($"{x} + {y} = {x+y}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{x} - {y} = {x-y}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{x} * {y} = {x*y}");
            //        break;
            //    default:
            //        Console.WriteLine("Please you input again correct !");
            //        break;
            //}

            var allowedOperations = new string[] {"*", "-", "+"};
            if(allowedOperations.Contains(operation))
            {
                var result = Calculate(x, y, operation);

                Console.WriteLine($"{x} {operation} {y} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid operator !");
            }
           

            Console.ReadLine();

        }

        private static int Calculate(int x, int y, string operation)
        {
            switch (operation)
            {
                case "+":
                    return  x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                default:
                    throw new Exception("Do not support this operation");
            }
        }
    }
}

