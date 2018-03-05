using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateIndividualCharactersAString
{
    class Program
    {
        public static void Main()
        {
            string str;
            int l = 0;

            Console.WriteLine("\nSeparate the individual characters from a string :");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();
            Console.WriteLine("The characters of the string are  :  ");
            while (l <= str.Length - 1)
            {
                Console.Write($"{str[l]} ");
                l++;
            }
            Console.ReadLine();
        }
    }
}
