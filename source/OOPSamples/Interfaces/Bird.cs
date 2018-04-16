using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bird:IFlyable
    {
        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("Bird flies");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
