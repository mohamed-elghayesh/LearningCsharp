using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing shapes
            Square sqr1 = new Square(20.25);
            Rectangle rec1 = new Rectangle(10, 5);
            Circle circ1 = new Circle(10);

            sqr1.GetInfo();
            Console.WriteLine();
            rec1.GetInfo();
            Console.WriteLine();
            circ1.GetInfo();

            // testing unique list example 
            Others.UniqueList<int> ul = new Others.UniqueList<int>() { 1,2,2,5,4,7,5,3,8};
            ul.RemoveDuplicates();
            foreach (var item in ul)
            {
                Console.Write(item + " ");
            }
        }
    }
}
