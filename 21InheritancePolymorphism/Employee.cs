using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    // abstract (contract)
    public abstract class Employee
    {
        public string FirstName { get; }
        public string  LastName { get; }
        public string SocialSecurityNumber { get; }

        // three parameter constructor
        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        // return string representation of employee object using properties
        public override string ToString() => $"{FirstName} {LastName}\n social security number: {SocialSecurityNumber}";

        // abstract earning method to be overriden by derived classes
        public abstract decimal Earnings();
    }

    // Concrete SalariedEmployee class that extends employee
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(weeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, decimal weeklySalary) : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public override decimal Earnings() => WeeklySalary;

        public override string ToString() => $" salaried employee: {base.ToString()} \n weekly salary: {WeeklySalary}";
    }

    // concrete HourlyEmployee class that extends employee
    public class HourlyEmployee
    {
        
    }
}
