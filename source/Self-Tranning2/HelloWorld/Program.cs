using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a interge number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a interge number b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of a + b is :" + Sum(a, b));
            Console.ReadLine();
        }

        private static int Sum(int a, int b) => a + b;
    }
}
