using System;
using System.Linq;

namespace InputThreeLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nInput letter 1:");
            //var letter1 = Console.ReadLine();

            //Console.WriteLine("\nInput letter 2:");
            //var letter2 = Console.ReadLine();

            //Console.WriteLine("\nInput letter 3:");
            //var letter3 = Console.ReadLine();

            //Console.Write($"Output them in reserve order: {letter3}, {letter2}, {letter1}");

            //string input = "hello world";
            //string output = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    output += input[i];
            //}

            string input = "hello world";
            string output = new string(input.ToCharArray().Reverse().ToArray());

            var output2 = new string(input.ToCharArray().OrderBy(x => x).ToArray());
            Console.WriteLine(output);
            Console.WriteLine(output2);

            Console.ReadLine();
        }
    }
}
