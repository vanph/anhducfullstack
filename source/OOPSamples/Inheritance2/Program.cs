using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
           var f = new Fish();
            f.Swim();

            var b = new Bird();
            b.Fly();

            Console.Read();

        }
    }
}
