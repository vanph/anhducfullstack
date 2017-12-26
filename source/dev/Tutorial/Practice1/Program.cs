using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3 & 5 below 1000:");

            var total = MultipleOf3And5(1000);

            Console.Write("Sum of all multiples 3 & 5 below 100 is :" + total);

            Console.ReadLine();
        }

       
        private static int MultipleOf3And5(int number)
        {
            int total = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total = total + i;
                }
            }

            return total;
        }
    }
}
