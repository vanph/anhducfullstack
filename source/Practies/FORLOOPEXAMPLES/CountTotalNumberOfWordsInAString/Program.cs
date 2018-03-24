using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTotalNumberOfWordsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, wrd, l;

            Console.WriteLine("\nCount the total number of words in a string :");
            Console.WriteLine($"------------------------------------------------------\n");
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.WriteLine($"Total number of words in the string is : {wrd}\n");
            Console.ReadLine();
        }
    }
}
