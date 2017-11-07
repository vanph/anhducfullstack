using System;
using System.Collections.Generic;

namespace Hellowolrd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine("Even numbers v1:");

            for (int i = 0; i < number; i++)
            {
                if (IsEvenNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Even numbers v2:");

            for (int i = 0; i < number; i= i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Print List:");

            var numbers = new List<int>(){3,5,6,7};

            PrintList(numbers);

            Console.ReadLine();
        }

        //method

        private static void PrintList(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        
        private static bool IsEvenNumber(int i)
        {
            return i % 2 == 0;
        }
    }
}
