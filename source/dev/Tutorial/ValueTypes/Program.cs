using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"max of int:{int.MaxValue}");
            //Console.WriteLine($"min of int:{int.MinValue}");
            //Console.WriteLine($"default of int:{default(int)}");

            //Console.WriteLine($"max of decimal:{decimal.MaxValue}");
            //Console.WriteLine($"max of double:{double.MaxValue}");
            Console.WriteLine("Please input a number:");
            //get number
            string numberText = Console.ReadLine();
            try
            {
                //int number = Convert.ToInt32(numberText);
                int givenNumber = int.Parse(numberText);
                //int.TryParse
                int sum = SumEvenNumbers(givenNumber);
               

                Console.WriteLine(sum);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                       
            //pause
            Console.ReadLine();           
        }

        private static int Sum(int number)
        {
            var sum = 0;

            for (var i = 1; i <= number; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        /// <summary>
        /// Sum of even numbers that less than or equal the given number
        /// </summary>
        /// <param name="givenNumber"></param>
        /// <returns></returns>
        private static int SumEvenNumbers(int givenNumber)
        {
            //For exmaple:
            //given number = 10
            //=> retunrn : 2 + 4 + 6 + 8 + 10
            //given number = 5 => return : 2+ 4

            var sum = 0;

            //for (var i = 1; i <= givenNumber; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        sum = sum + i;
            //    }               
            //}

            for (var i = 2; i <= givenNumber; i=i+2)
            {
                sum = sum + i;
            }

            return sum;
        }

    }
}
