using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Ngo anh duc van";
            var welcomeMessage = name.SayHello();
            var welcomeMessage2 = SayHello(name);
            var wordCount = name.WordCount();
            Console.WriteLine(wordCount);

            Console.WriteLine(welcomeMessage);
            Console.WriteLine(welcomeMessage2);

            List<int> lst = new List<int>(){2, 4, 66, 5, 7, 18, 8, 3};
            var oddNumbers = lst.GetOddNumbers();

            var arr = new int[] { 2, 3, 9 };
            var oddNumbers2 = arr.GetOddNumbers();

            Print(oddNumbers);
            Print(oddNumbers2);


            var p = new Person() {FirstName = "Van", LastName = "Pham", DoB = new DateTime(1987, 9, 26)};
            p.Welcome();
            Console.WriteLine(p.CalculateAge());


            Console.ReadLine();
        }

        public static string SayHello( string source)
        {
            return $"Hello {source}";
        }


        private static void Print(IEnumerable<int> lst)
        {
            Console.WriteLine("Print List:");
            foreach (var item in lst)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
