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
            Console.WriteLine($"Display the cube of the number:");
            Console.WriteLine("---------------------------------");
            Console.Write($"Input number of terms : ");
            int ctr = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ctr; i++)
                //Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                Console.WriteLine($"Cube of number {i} is : {i*i*i} ");
                Console.ReadLine();
        }
    }
}
