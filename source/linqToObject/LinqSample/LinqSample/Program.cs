using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = new int[] {2, 5, 8, 1,11}; //array -> IEnumerable  
            //Print(arr);
            var lst = new List<int>() {2, 5, 8, 1};
            Print(lst);
            

            //get max:
            var max = lst.Max();
            Console.WriteLine($"max: {max}");

            var orderredList = lst.OrderBy(x => x);
            Print(orderredList);

            var sum1 = lst.Sum();
            var sum2 = MySum(lst);

            Console.WriteLine($"sum: {sum1} - {sum2}");

            Linq74();

            Console.ReadLine();
        }

        public static void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }
        private static int MySum(IEnumerable<int> lst)
        {
            var result = 0;

            foreach (var i in lst)
            {
                result = result + i;
            }

            return result;
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
