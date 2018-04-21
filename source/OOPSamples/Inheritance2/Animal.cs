using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    abstract class Animal
    {
        protected abstract bool CheckAlive();

        protected virtual void Move()
        {
            if (CheckAlive())
            {
                Console.WriteLine("Moving...");
            }
            else
            {
                Console.WriteLine("Dead! Cannot move");
            }
            
        }

        public void Eat()
        {
            if (CheckAlive())
            {
                Console.WriteLine("animal eats");
            }
            else
            {
                Console.WriteLine("Dead! Cannot eat");
            }
        }
    }
}
