using System;

namespace Polymorphism
{
    class Rectangle:Shape
    {
        public Rectangle(int width = 0, int height = 0) : base(width, height)
        {

        }

        public override decimal Area()
        {
            //Console.WriteLine("Rectangle class area :");
            return (Width * Height);
        }

      
    }
}