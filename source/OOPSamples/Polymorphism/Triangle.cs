using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Triangle:Shape
    {
        public Triangle(int width = 0, int height = 0) : base(width, height)
        {

        }

        public override decimal Area()
        {
            //Console.WriteLine("Triangle class area :");
            return (Width * Height)*1.0m/2;
        }

    }
}
