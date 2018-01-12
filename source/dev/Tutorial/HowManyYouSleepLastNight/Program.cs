using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyYouSleepLastNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hours of sleep did you get last night?");

            string numberText = Console.ReadLine();

            int numberHourSleep = int.Parse(numberText);
            
            if (numberHourSleep < 8)
            {
                Console.WriteLine("You need more sleep !");
            }
            else
            {
                Console.WriteLine("You are well rest !");
            }

            Console.ReadLine();
        }
    }
}
