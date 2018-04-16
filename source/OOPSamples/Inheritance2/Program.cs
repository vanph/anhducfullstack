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
            //var f = new Fish(true);
            //f.Swim();

            var deadFish= new Fish(false);
            deadFish.Swim();

            // var b = new Bird();
            // b.Fly();


            //var m = new Mammal(){Name = "Cat"};
            //m.Run();

            Console.Read();

        }
    }
}
