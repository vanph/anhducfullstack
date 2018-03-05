using System;
using System.Linq;

namespace FindSumOfAllElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n;


            Console.WriteLine("Find sum of all elements of array:");
            Console.WriteLine("--------------------------------------");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {n} elements in the array :");
            for (i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //var b = new int[4] {1, 2, 3, 5};
            //var sum = b.Sum();
            //var sum = SumArray(a);
            var sum = a.Sum();
            var max = a.Max();
            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
            Console.WriteLine($"Max element stored in the array is : {max}");
            Console.ReadLine();
        }

        private static int SumArray(int[] a)
        {
            var sum = 0;
            
            for (var i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }

     
    }
}