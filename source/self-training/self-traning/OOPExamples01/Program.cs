using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples01
{
    class Program
    {
        static void TestEmloyee()
        {
            OfficialEmployee duc = new OfficialEmployee();
            duc.Id = 1;
            duc.Name = "Ngo Anh Duc";
            Console.WriteLine($"Luong cua { duc.Name} = ");
            duc.Payroll();
            UnofficialEmployee hoang = new UnofficialEmployee();
            hoang.Id = 2;
            hoang.Name = "Vuong Ngoc Hoang";
            Console.WriteLine($"Luong cua {hoang.Name} = ");
            hoang.Payroll();
        }

        static void TestEmployee2()
        {
            OfficialEmployee duc = new OfficialEmployee();
            int salary = duc.Payroll(20);
            Console.WriteLine($"Luong cua Duc = {salary}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestEmloyee();
            TestEmployee2();
            Console.ReadLine();
        }
    }
}
