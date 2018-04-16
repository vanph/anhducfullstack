using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("ngo", "duc"){Dob = new DateTime(1984,1,1)};
            //p is object/ instance

            //var p1 = new Person();
            
            p.PrintName();
            
            var t = new Teacher("pham", "van")
            {
                Dob = new DateTime(1987, 9, 26)
            };

            t.PrintName();
            t.ShowTeacherInfo();
            Console.Read();

        }
    }
}
