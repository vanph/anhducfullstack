using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    abstract class Animal
    {
        protected virtual void Move()
        {
            Console.WriteLine("Moving...");
        }

    }
}
