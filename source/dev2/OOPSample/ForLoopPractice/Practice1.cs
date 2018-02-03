using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPractice
{
  public  class Practice1
    {
        //Write a program in C# Sharp to display the first 10 natural numbers
        public void Test()
        {
            Console.WriteLine("Display the first 10 natural numbers:\n");
            Console.WriteLine("---------------------------------------");
           
            for (var i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
