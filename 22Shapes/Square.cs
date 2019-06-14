using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public double Length { get; set; }

        public Square(double length)
        {
            Name = "Square";
            Length = length;
        }

        public override double GetArea()
        {
            return Math.Pow(Length, 2);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name}'s length is {Length}");
        }

        public override double GetPerimeter()
        {
            return Length * 4;
        }
    }

    class Rectangle : Square
    {
        public double Width { get; set; }

        public Rectangle(double length, double width) : base(length)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        //rectangle must override all square methods
        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name}'s width is {Width}");
        }
    }
}
