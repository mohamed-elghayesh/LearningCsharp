using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {// TODO 1: email this to Mai
            CounterCreationDataCollection counters = new CounterCreationDataCollection();

            CounterCreationData totalOrders = new CounterCreationData();
            totalOrders.CounterName = "# Orders";
            totalOrders.CounterHelp = "Total number of orders placed";
            totalOrders.CounterType = PerformanceCounterType.NumberOfItems32;

            CounterCreationData ordersPerSecond = new CounterCreationData();
            ordersPerSecond.CounterName = "# Orders/Sec";
            ordersPerSecond.CounterHelp = "Number of orders placed per second";
            ordersPerSecond.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;

            counters.Add(totalOrders);
            counters.Add(ordersPerSecond);

            // needs elevated permissions to create the counter on the windows machine
            PerformanceCounterCategory.Create("MyOrdersCategories", "A sample demonstration", PerformanceCounterCategoryType.SingleInstance, counters);

            // call order coffee
            Program p = new Program();
            p.OrderCoffee();
        }

        // get reference to the custom counters by category name and counter name
        PerformanceCounter countOrders = new PerformanceCounter("MyOrdersCategories", "# Orders", false);
        PerformanceCounter countOrdPerSec = new PerformanceCounter("MyOrdersCategories", "# Orders/Sec", false);

        // update counters any where like this
        public void OrderCoffee()
        {
            countOrders.Increment();
            countOrdPerSec.Increment();
            // other code
        }
    }
}
