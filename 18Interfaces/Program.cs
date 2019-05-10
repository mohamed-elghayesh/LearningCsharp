using System;
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
            ILoyaltyCardHolder ic2 = new Customer();
            ic2 = c1;
            c1 = (Customer)ic2;

            Partner p1 = new Partner();
            ILoyaltyCardHolder ip2 = new Partner();
            ip2 = p1;
            p1 = (Partner)ip2;

            List<ILoyaltyCardHolder> l1 = new List<ILoyaltyCardHolder>();
            l1.Add(c1);
            l1.Add(ic2);
            l1.Add(p1);
            l1.Add(ip2);

            Console.ReadLine();
        }
    }
}
