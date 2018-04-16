using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Fish:Animal
    {
        public void Swim()
        {
            base.Move();
            Console.WriteLine("Swimming...");
        }
    }
}
