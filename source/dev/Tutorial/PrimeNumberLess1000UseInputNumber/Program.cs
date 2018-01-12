using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberLess1000UseInputNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");
            string numberText = Console.ReadLine();
            
            try
            {
                int givenNumber = int.Parse(numberText);

                PrintPrimeNumbers(givenNumber);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static void PrintPrimeNumbers(int givenNumber)
        {
            Console.WriteLine("Prime Numbers are: ");

            for (int i = 2; i < givenNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write("\t" + i);
                }
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
