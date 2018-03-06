using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5]{1,3,6,7,866};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine();

            var arrString = new string[3] { "pham hong van", "ngo anh duc", "bui quang hieu" };

            foreach (var item in arrString)
            {
                Console.WriteLine(item);
            }

            var str = "pham hong van";// array of characters
            //var c = 'P'; // c is a character
            //var d = "P";// d is a string
            Console.WriteLine(str.Length);
            foreach (var c in str)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
