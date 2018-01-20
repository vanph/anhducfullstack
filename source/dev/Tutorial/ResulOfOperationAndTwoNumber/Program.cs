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

            OperatorEnum? myOperator = GetOperator(operation);

            if (myOperator.HasValue)
            {
                var calculation = new Calculation();
                var result = calculation.Calculate(x, y, myOperator.Value);

                Console.WriteLine($"{x} {operation} {y} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid operator !");
            }

            Console.ReadLine();

        }

        private static OperatorEnum? GetOperator(string operationString)
        {
            switch (operationString)
            {
                case "+":
                case "Add":
                    return OperatorEnum.Addition;
                case "-":
                case "Subtract":
                    return OperatorEnum.Substraction;
                case "*":
                case "Multiply":
                    return OperatorEnum.Multiplication;

                case "/":
                case "Devide":
                    return OperatorEnum.Division;

                default:
                    return null;
            }
        }
    }
}

