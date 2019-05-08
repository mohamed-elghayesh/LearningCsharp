using System;

namespace LearningCsharp
{
    class Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number, press enter, then a divisor: ");
            int num1 = int.Parse(Console.ReadLine());
            int divisor = int.Parse(Console.ReadLine());
            
            // Instance method (not static, needs instantiation)
            Methods Meth = new Methods();
            Meth.IsEven(num1);
            
            // Class method (called directly from the class)
            bool divisible = DivBy(num1, divisor);
            Console.WriteLine("Divisibility is: " + divisible);

            // Method with ref in parameters
            int number = 1;
            Add(ref number);
            Console.WriteLine(number);

            Console.ReadLine();
        }

        // CLR treats the int as a reference type
        private static void Add(ref int num)
        {
            num += 20;
        }

        // static, class method divisible by
        private static bool DivBy(int myInt, int dinimonator)
        {
            if (myInt % dinimonator == 0) return true;
            else return false;
        }
        
        // non static, instance method
        void IsEven(int myInt)
        {
            if (myInt % 2 == 0) Console.WriteLine("The number is even.");
            else Console.WriteLine("The number is odd.");
        }
    }
}
