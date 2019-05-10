using System;
using System.Collections;
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
            // Create some instances of the Coffee class.
            Coffee coffee1 = new Coffee();
            coffee1.AverageRating = 4.5;
            Coffee coffee2 = new Coffee();
            coffee2.AverageRating = 8.1;
            Coffee coffee3 = new Coffee();
            coffee3.AverageRating = 7.1;
            
            // Add the Coffee instances to an ArrayList.
            ArrayList coffeeList = new ArrayList();
            coffeeList.Add(coffee1);
            coffeeList.Add(coffee2);
            coffeeList.Add(coffee3);
            
            // Sort the ArrayList by average rating.
            coffeeList.Sort(new CoffeeRatingComparer());
            foreach (Coffee item in coffeeList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public class Coffee
    {
        public double AverageRating { get; set; }
        public string Variety { get; set; }

        public override string ToString()
        {
            return this.AverageRating.ToString();
        }
    }

    public class CoffeeRatingComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            Coffee coffee1 = x as Coffee;
            Coffee coffee2 = y as Coffee;
            double rating1 = coffee1.AverageRating;
            double rating2 = coffee2.AverageRating;
            return rating1.CompareTo(rating2);
        }
    }
}
