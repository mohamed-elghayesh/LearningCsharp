﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.AddPoints(10);
            Console.WriteLine(c1.TotalPoints);
            c1.ResetPoints();
            Console.WriteLine(c1.TotalPoints);

            Console.ReadLine();
        }
    }
}
