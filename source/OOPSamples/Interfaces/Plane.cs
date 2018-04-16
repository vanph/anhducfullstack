using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //implement
    class Plane:IFlyable
    {
        public string Brand { get; set; }
        public void Fly()
        {
            Console.WriteLine($"Plane {Brand} flies");
        }
        
    }
}
