using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class ValueRef
    {
        static void Main(string[] args)
        {
            #region difference between value and reference types
            // class is reference type
            Rectangle r1, r2;
            r1 = new Rectangle();
            r1.Length = 10;
            r1.Width = 20;
            r2 = r1;
            r2.Length = 30;
            Console.WriteLine(r1.Length);

            // struct is value type
            Square s1, s2;
            s1 = new Square();
            s1.Side = 10;
            s2 = s1;
            s2.Side = 30;
            Console.WriteLine(s1.Side);
            #endregion

            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }

    struct Square
    {
        public double Side { get; set; }
    }
}
