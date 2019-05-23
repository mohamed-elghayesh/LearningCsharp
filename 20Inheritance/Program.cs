using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    class CommissionEmployeeTest
    {
        static void Main()
        {
            #region CommissionEmployee Test
            // CommissionEmployee: instantiation
            var e1 = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            // display CommissionEmployee data
            Console.WriteLine("Employee 1 information obtained by properties and methods:");
            Console.WriteLine($"First name is {e1.FirstName}");
            Console.WriteLine($"Last name is {e1.LastName}");
            Console.WriteLine($"Social security number is {e1.SocialSecurityNumber}");
            Console.WriteLine($"Commission rate is {e1.CommissionRate}");
            Console.WriteLine($"Gross sales is {e1.GrossSales}");
            Console.WriteLine($"Earnings are { e1.Earnings():C}");

            // CommissionEmployee: setting some properties
            e1.GrossSales = 5000.00M;
            e1.CommissionRate = .1M;
            Console.WriteLine($"\nUpdated employee information from ToString() \n{e1}");
            Console.WriteLine($"\nEarnings {e1.Earnings():C}");
            #endregion

            #region SalaryCommissionEmployee Test
            // CommissionEmployee: instantiation
            var e2 = new SalaryCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M,300.00M);

            // display CommissionEmployee data
            Console.WriteLine("\nEmployee 2 information obtained by properties and methods:");
            Console.WriteLine($"First name is {e2.FirstName}");
            Console.WriteLine($"Last name is {e2.LastName}");
            Console.WriteLine($"Social security number is {e2.SocialSecurityNumber}");
            Console.WriteLine($"Commission rate is {e2.CommissionRate:F2}");
            Console.WriteLine($"Gross sales is {e2.GrossSales:C}");
            Console.WriteLine($"Salary is {e2.Salary:C}");
            Console.WriteLine($"Earnings are { e2.Earnings():C}");

            // CommissionEmployee: setting some properties
            e2.Salary = 1000.00M;
            Console.WriteLine($"\nUpdated employee information from ToString() \n{e2}");
            Console.WriteLine($"\nEarnings {e2.Earnings():C}");
            #endregion

            #region BaseSalaryCommissionEmployee Test
            // CommissionEmployee: instantiation
            var e3 = new BaseSalaryCommissionEmployee("Ali", "Kamel", "444-44-4444", 8000.00M, .029M, 800.00M);

            // display CommissionEmployee data
            Console.WriteLine("\nEmployee 3 information obtained by properties and methods:");
            Console.WriteLine($"First name is {e3.FirstName}");
            Console.WriteLine($"Last name is {e3.LastName}");
            Console.WriteLine($"Social security number is {e3.SocialSecurityNumber}");
            Console.WriteLine($"Commission rate is {e3.CommissionRate:F2}");
            Console.WriteLine($"Gross sales is {e3.GrossSales:C}");
            Console.WriteLine($"Salary is {e3.BaseSalary:C}");
            Console.WriteLine($"Earnings are { e3.Earnings():C}");

            // CommissionEmployee: setting some properties
            e3.BaseSalary = 900.00M;
            Console.WriteLine($"\nUpdated employee information from ToString() \n{e3}");
            Console.WriteLine($"\nEarnings {e3.Earnings():C}");
            #endregion

            Console.ReadLine();
        }
    }
}
