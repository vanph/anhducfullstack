using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Mammal:Animal
    {
        public string Name { get; set; }
        private void PrintMammal()
        {
            Console.WriteLine($"Hello {Name}");
        }
        public void Run()
        {
            PrintMammal();
            base.Move();
            Console.WriteLine($"{Name} running...");
        }

        protected override bool CheckAlive()
        {
            return true;
        }
    }
}
