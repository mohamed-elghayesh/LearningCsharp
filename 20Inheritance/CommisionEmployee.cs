using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public class CommissionEmployee : Object
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        protected decimal grossSales; // gross weekly sales, internal for inheritance
        protected decimal commissionRate; //commision percentage, internal for inheritance

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

        // five parameters constructor
        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
        {
            // implicit call to object's constructor happens here
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales; // validates gross sales
            CommissionRate = commissionRate; // validates commission rate
        }

        // calculate commission employee's pay (Expression Bodied Method)
        public virtual decimal Earnings() => commissionRate * grossSales;

        // return a string representation of commision employee object (Expression Bodied Method)
        public override string ToString() => $"commission employee: {FirstName} {LastName} \n" +
                                             $"social security number: {SocialSecurityNumber} \n" +
                                             $"gross sales: {GrossSales:C} \n" +
                                             $"commission rate: {commissionRate:F2}";
        
    }
}
