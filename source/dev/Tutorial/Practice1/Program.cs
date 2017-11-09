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
            int total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    total = total + i;
                }
            }
            Console.Write("Sum of all multiples 3 & 5 below 100 is :" + total);

            Console.ReadLine();
        }
    }
}
