using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IOperations
    {
        double GetArea();
        double GetPerimeter();
        void GetInfo();
    }

    // no constructor, cannot be instantiated
    public abstract class Shape : IOperations
    {
        public string Name { get; set; }

        public abstract double GetArea();
        
        public abstract double GetPerimeter();

        public virtual void GetInfo()
        {
            Console.WriteLine($"The {Name}'s area is {GetArea()} " +
                $"and perimeter is {GetPerimeter()}");
        }
    }

}
