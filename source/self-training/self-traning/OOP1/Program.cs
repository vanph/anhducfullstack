using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Student teo = new Student
            {
                Ten = "Nguyễn Văn Tèo",
                Ma = 111
            };
            Console.WriteLine(teo);
            Console.ReadLine();
        }
    }
}
