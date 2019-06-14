// most of the variables and methods in this class are copied from the CommissionEmployee class
// this is error prone (can spread errors), time consuming, redundant and hard to maintain.
// use inheritance instead to absorb the base class functionality into the derived class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    class SalaryCommissionEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        private decimal grossSales; //gross weekly sales
        private decimal commissionRate; //commision percentage
        private decimal salary;

        // grossSales getter and setter property
        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0) //validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }

        // commisionRate getter and setter property
        public decimal CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value <= 0 || value >= 1) //validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }
                commissionRate = value;
            }
        }

        // salary getter and setter
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Salary)} must be >= 0");
                }
                salary = value;
            }
        }

        // six parameter constructor
        public SalaryCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal salary)
        {
            // implicit call to object's constructor happens here
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales; // validates gross sales
            CommissionRate = commissionRate; // validates commission rate
            Salary = salary; // validate salary
        }

        // calculate commission employee's pay (Expression Bodied Method)
        public decimal Earnings() => salary + commissionRate * grossSales;

        // return a string representation of commision employee object (Expression Bodied Method)
        public override string ToString() => $"commission employee: {FirstName} {LastName} \n" +
                                             $"social security number: {SocialSecurityNumber} \n" +
                                             $"gross sales: {grossSales:C} \n" +
                                             $"commission rate: {commissionRate:F2} \n"+
                                             $"salary: {salary:C}";
    }
}
