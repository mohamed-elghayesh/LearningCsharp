using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class BaseSalaryCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;

        // 6 parameter derived class constructor with call to base class 5 parameters constructor
        public BaseSalaryCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
                                    : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be >= 0");
                }
                baseSalary = value;
            }
        }

        public override decimal Earnings() => BaseSalary + base.Earnings();

        public override string ToString() => $"base info: {base.ToString()} \nSalary: {BaseSalary:C}";

        // return a string representation of commision employee object (Expression Bodied Method)
        // public override string ToString() => $"commission employee: {FirstName} {LastName} \n" +
        //                                     $"social security number: {SocialSecurityNumber} \n" +
        //                                     $"gross sales: {grossSales:C} \n" +
        //                                     $"commission rate: {commissionRate:F2} \n" +
        //                                     $"salary: {baseSalary:C}";
    }
}
