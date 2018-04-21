using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class AreaCalculator
    {
        public void PrintArea(Shape sh)
        {
            var a = sh.Area();
            Console.WriteLine("Area: {0}", a);
        }

        public decimal GetArea(IEnumerable<Shape> shapes)
        {
            decimal area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
