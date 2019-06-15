using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18InterfacesIEnumerableVsIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>() { 1990, 1993, 1998, 2002, 2003, 2015 };
            Console.WriteLine("\nSimple Iteration \n");

            // Implementing IEnumerable (stateless)
            IEnumerable<int> ienum = years;
            foreach (var item in ienum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Implementing the IEnumarator (remember state)
            IEnumerator<int> irator = years.GetEnumerator();
            while (irator.MoveNext())
            {
                Console.WriteLine(irator.Current);
            }

            // resetting irator
            irator.Reset();
            Console.WriteLine();

            // using the state test methods 
            Console.WriteLine("IEnumerator \n");
            GetEarlyYears(irator);
        }

        static void GetEarlyYears(IEnumerator<int> irator)
        {
            while (irator.MoveNext())
            {
                if (irator.Current < 2000)
                {
                    Console.WriteLine($"{irator.Current} - IEnumerator from Early Years");
                }
                else GetLaterYears(irator);
            }
        }

        static void GetLaterYears(IEnumerator<int> irator)
        {
            Console.WriteLine();
            while (irator.MoveNext())
            {
                Console.WriteLine($"{irator.Current} - IEnumerator from Later Years");
            }
        }
    }
}
