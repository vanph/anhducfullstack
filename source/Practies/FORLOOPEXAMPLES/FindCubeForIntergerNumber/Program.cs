using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCubeForIntergerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display the cube of the number:");
            Console.WriteLine("---------------------------------");
            Console.Write("Input number of terms : ");

            var ctr = Convert.ToInt32(Console.ReadLine());

            PrintCube(ctr);

            Console.ReadLine();
        }

        private static void PrintCube(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Cube of number {i} is : {Math.Pow(i, 3)} ");
            }
        }
    }
}
