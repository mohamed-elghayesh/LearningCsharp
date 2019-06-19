using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MethodsExtension
{
    static class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("1/5/2025");
            DateTime time = DateTime.Parse("1/1/0001 9:55pm");
            
            DateTime combined = Combine(date, time);
            DateTime combined2 = date.Combine(time);

            Console.WriteLine(combined);
            Console.WriteLine(combined2);

            Console.WriteLine(date.MyToString());
        }

        static DateTime Combine(this DateTime date, DateTime time)
        {
            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        static string MyToString(this Object obj)
        {
            return $"Hello {obj.ToString()}";
        }
    }
}
