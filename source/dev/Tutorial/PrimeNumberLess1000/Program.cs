using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberLess1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers are: ");

            for (int i = 2; i < 1000; i++)
            {
                if(IsPrimeNumber(i))
                {
                    Console.Write("\t" + i);
                }              
            }
            
            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int number)
        {            
            for (int i = 2; i< number; i ++ )
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
