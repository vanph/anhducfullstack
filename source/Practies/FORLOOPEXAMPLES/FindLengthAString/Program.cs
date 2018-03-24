using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLengthAString
{
    class Program
    {
        static void Main()
        {
            string str; /* Declares a string of size 100 */
            int l = 0;

            Console.WriteLine("\n\nFind the length of a string :");
            Console.WriteLine("---------------------------------");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.WriteLine($"Length of the string is : {l}\n");
            Console.ReadLine();
        }
    }
}
