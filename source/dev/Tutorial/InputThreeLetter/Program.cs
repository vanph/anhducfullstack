using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputThreeLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput letter 1:");
            String letter1 = Console.ReadLine();

            Console.WriteLine("\nInput letter 2:");
            String letter2 = Console.ReadLine();

            Console.WriteLine("\nInput letter 3:");
            String letter3 = Console.ReadLine();

            Console.Write("Output theme in reserve order:" + letter3 + letter2 + letter1);
            Console.ReadLine();
        }
    }
}
