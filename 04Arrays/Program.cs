using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCsharp
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Declaring array
            string[] names = { "Ali", "Mona", "Mai", "Andy", "Kamal" };
            int[] age = { 30, 25, 28, 32, 22 };
            Console.WriteLine("Name: {0} | Age: {1}", names[0], age[0]);
            
            // sorting array age
            Array.Sort<int>(age);
            Console.WriteLine(age[0]);
            Console.WriteLine(age[1]);
            Console.WriteLine(age[2]);
            Console.WriteLine(age[3]);
            Console.WriteLine(age[4]);

            // Assigning array elements
            int[] temprature = new int[4];
            temprature[0] = 15;
            temprature[1] = 13;
            temprature[2] = 18;
            temprature[3] = 15; // temprature[4] --> outOfBound exception

            // Some Array methods
            Console.WriteLine("15 13 18 15");
            Console.WriteLine("temprature[0] first: {0}", temprature.First());
            Console.WriteLine("Average temprature: {0}", temprature.Average());
            Console.WriteLine("count of temp data: {0}", temprature.Count());
            Console.WriteLine("temprature[1] element: {0}", temprature.ElementAt(1));
            Console.WriteLine("temprature[3] value: {0}", temprature.GetValue(3));
            Console.WriteLine("maximum of temp data: {0}", temprature.Max());
            Console.WriteLine("reverse temprature[1]: {0}", temprature.Reverse().ElementAt(1));
            Console.WriteLine("sum of array data: {0}", temprature.Sum());

            // convert array[] to a List, use Linq to order the List
            var elements = temprature.ToList();
            var ordList = from items in elements
                          orderby items
                          select items;
            Console.WriteLine(ordList.ElementAt(0)+", "+ ordList.ElementAt(1) + ", "+ ordList.ElementAt(2) + ", "+ ordList.ElementAt(3));

            // using loops with arrays "traversing"
            for (int i = 0; i < names.Count(); i++)
            {
                Console.Write("Hello {0} | ",names[i]);
            }

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.Write("Hello {0} | ", name);
            }

            Console.WriteLine();

            // copying arrays using Copy()
            var sourceArray = new int[] { 11, 12, 3, 5, 2, 9, 28, 17 };
            var destinationArray = new int[3];
            Array.Copy(sourceArray, destinationArray, 3);

            // copying using CopyTo()
            sourceArray = new int[] { 11, 12, 7 };
            destinationArray = new int[6];
            sourceArray.CopyTo(destinationArray, 2); // destination array: 0 0 11 12 7 0

            // cloning an array
            sourceArray = new int[] { 11, 12, 7 };
            destinationArray = (int[])sourceArray.Clone();

            // arrays equality
            int[] arr1 = { 3, 5, 7 };
            int[] arr2 = { 3, 5, 7 };
            bool result = arr1.SequenceEqual(arr2);
            Console.WriteLine("Arrays equal? {0}", result);

            // Multidimension arrays arr[row,col]
            int[,] arr = new int[4, 2] { { 1, 7 }, { 0, 2 }, { 2, 3 }, { 6, 4 } };
            Console.WriteLine("arr[3,1]: {0}", arr[3, 1]); // 4

            // Jagged arrays or array of arrays
            Console.WriteLine("Jagged array in action.");
            int[][] employees = new int[3][]; // employee has 3 arrays (columns)
            employees[0] = new int[4];
            employees[1] = new int[4];
            employees[2] = new int[4];

            employees[0][0] = 1;
            employees[0][1] = 2;
            employees[0][2] = 3;

            employees[1][0] = 30;
            employees[1][1] = 28;
            employees[1][2] = 31;

            employees[2][0] = 4200;
            employees[2][1] = 2800;
            employees[2][2] = 3900;

            for (int i = 0; i < employees.Count(); i++)
            {
                for (int j = 0; j < employees[0].Count(); j++)
                {
                    Console.Write(employees[i][j] + " ");
                }
            }


            Console.ReadLine();
        }
    }
}
