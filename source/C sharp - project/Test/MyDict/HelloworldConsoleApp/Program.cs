using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args != null && args.Length >0)
            {
                Console.WriteLine($"Hello world! Welcome {args[0]}");
            }
            else
            {
                Console.Write("Duc");
                Console.WriteLine("Hello world");
            }
            

            Console.ReadLine();
        }
    }
}
