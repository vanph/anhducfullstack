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
            bool PrimeNumberCorrect = true;
            Console.WriteLine("PrimeNumber is: ");
            for (int i = 2; i<1000; i++)
            {
                for (int j = 2; j< 1000; j++)
                {
                    if (i != j && i % j ==0)
                    {
                        PrimeNumberCorrect = false;
                        break;
                    }
                }
                if (PrimeNumberCorrect)
                {
                    Console.Write("\t" + i);
                }
                PrimeNumberCorrect = true;
            }
            Console.ReadKey();
        }
    }
}
