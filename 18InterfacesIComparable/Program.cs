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
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "Steve", Salary = 10000 });
            list.Add(new Employee() { Name = "Janet", Salary = 10000 });
            list.Add(new Employee() { Name = "Andrew", Salary = 10000 });
            list.Add(new Employee() { Name = "Bill", Salary = 500000 });
            list.Add(new Employee() { Name = "Lucy", Salary = 8000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }

    class Employee : IComparable<Employee>
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        // implementing the IComparable member method
        public int CompareTo(Employee other)
        {
            // Alphabetic sort if salary is equal. [A to Z]
            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to salary sort. [High to low]
            return other.Salary.CompareTo(this.Salary);
        }

        // override the ToString() method to provide information Employee to client code
        public override string ToString()
        {
            // String representation.
            return this.Salary.ToString() + "," + this.Name;
        }
    }
}
