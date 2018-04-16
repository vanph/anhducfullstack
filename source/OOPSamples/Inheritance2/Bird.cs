using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //inherite / extend
    class Bird : Animal
    {
        public void Fly()
        {
            //base.Move();
            Move();
            Console.WriteLine("Flying...");
        }

        protected override void Move()
        {
            Console.WriteLine("Bird is moving...");
        }
    }
}
