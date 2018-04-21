using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   abstract class Shape
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        protected Shape(int width = 0, int height = 0)
        {
            Width = width;
            Height = height;
        }
        public virtual decimal Area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }

    }
}
