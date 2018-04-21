using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaCalculator= new AreaCalculator();
           
            var r = new Rectangle(10, 7); //70
            var t = new Triangle(4, 3);//6
         
            var shapes = new List<Shape>(){r,t};

            var totalArea = areaCalculator.GetArea(shapes);

            Console.WriteLine(totalArea);
            Console.ReadLine();
        }
    }
}
