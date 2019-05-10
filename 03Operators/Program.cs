using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Operators
    {
        static void Main(string[] args)
        {
            #region Relational operators
            /*
            // binary operators
            if ("a" == "a") Console.WriteLine("a == a");
            else Console.WriteLine("false if");

            if ("a" == "b") Console.WriteLine("a == b");
            else Console.WriteLine("false if");

            if (1 == 1.0) Console.WriteLine("1 == 1.0");
            else Console.WriteLine("false if");

            if (1.0 == 1) Console.WriteLine("1.0 == 1");
            else Console.WriteLine("false if");

            if (1.0 != 1) Console.WriteLine("1.0 == 1");
            else Console.WriteLine("false if");

            if (1.0 >= 1) Console.WriteLine("1.0 == 1");
            else Console.WriteLine("false if");

            if (1.0 <= 1) Console.WriteLine("1.0 == 1");
            else Console.WriteLine("false if");

            // if (1.0 == new object()) Console.WriteLine("1.0 == new oject()");

            // ternary short if operator
            bool result = "a" == "b" ? true : false;
            Console.WriteLine("Result is: " + result);

            string x = "5";
            float y = 10.5f;
            Console.WriteLine("x > y : {0}", int.Parse(x) > y ? "True" : "False"); // int.Parse(string)
            Console.WriteLine("x > y : {0}", Convert.ToInt16(x) > y ? "True" : "False"); // Convert.ToInt16(string)


            /*value types return true if the are equal in value
             reference types as classes objects return true if they they are equal in reference 
            */
            
            #endregion

            #region Increment Decrement
            // increment and decrement a variable
            int myNum1 = 5;
            int myNum2 = 10;

            Console.WriteLine("number is: {0}", myNum1);
            Console.WriteLine("number++ is: {0}", myNum1++);
            Console.WriteLine("number is: {0}", myNum1);

            Console.WriteLine("number is: {0}", myNum2);
            Console.WriteLine("++number is: {0}", ++myNum2);
            Console.WriteLine("number is: {0}", myNum2);

            // Assigning with += -= /= *= %= &= |= ^= <<= >>=
            float boys = 10;
            float girls = 8;
            bool isBigger = true;

            Console.WriteLine("boys: {0}, girls: {1}",boys,girls);
            Console.WriteLine("boys += girls: {0}",boys += girls);  
            Console.WriteLine("boys -= girls: {0}", boys -= girls);
            Console.WriteLine("boys /= girls: {0:0.000}", boys /= girls);
            Console.WriteLine("boys *= girls: {0}", boys *= girls);
            Console.WriteLine("isBigger: {0}", isBigger);
            Console.WriteLine("isBigger |= false: {0}", isBigger |= false);
            Console.WriteLine("isBigger &= false: {0}", isBigger &= false);
            

            #endregion

            #region Logical operators
            bool a = true;
            bool b = false;

            if (b & a)
            {
                Console.WriteLine("b & a is True");
            }

            // short circuit "And"
            if (a && a)
            {
                Console.WriteLine("a && a is True");
            }

            if (a && b)
            {
                Console.WriteLine("a && b is False");
            }

            if (b && a)
            {
                Console.WriteLine("b && a is False");
            }

            if (b | a)
            {
                Console.WriteLine("b | a is True");
            }

            // short circuit "Or"
            if (a || b)
            {
                Console.WriteLine("a || b is True");
            }

            Console.WriteLine("b || a is {0}", b || a ? "True" : "False");

            // XOR
            Console.WriteLine("a XOR a is {0}", a ^ a ? "True" : "False");
            Console.WriteLine("b XOR a is {0}", b ^ a ? "True" : "False");

            #endregion

            #region Bit-shifting operators
            // doubling and redoubling an int using shifting
            int num1 = 3;
            int num2 = 6;
            Console.WriteLine("3 << 1: {0}", num1 << 1);
            Console.WriteLine("6 << 2: {0}", num2 << 2);
            Console.WriteLine("5 << 1: {0}", 5 << 1);
            Console.WriteLine("5 << 2: {0}", 5 << 2);

            // dividing by 2 using shifting
            Console.WriteLine("100 >> 1: {0}", 100 >> 1);
            Console.WriteLine("100 >> 2: {0}", 100 >> 2);
            Console.WriteLine("100 >> 3: {0}", 100 >> 3);

            #endregion
    
            #region Lambda operator

            // count each element and get the min string
            string[] fruits = {"apple","orange","banana","ki","mango" };
            Console.WriteLine("fruits array members length: {0}", fruits.Length);

            Console.WriteLine("Min characters in a fruit: {0}", fruits.Min(f => f.Length));

            // apply process to array[int] elements
            int[] nums = {1, 2, 3, 4};
            int[] squares = nums.Select(n => n * n).ToArray();

            for (int l = 0; l < nums.Length; l++)
            {
                Console.WriteLine(nums[l] + " : " + squares[l]);
            }

            Array.ForEach(nums, n => Console.WriteLine(n + " || " + Math.Pow(n, 2)));

            #endregion

            #region Nullable operator

            // the ? nullable operator
            int? i = 5;
            int? j = null;
            Nullable<int> k = 6;
            int? sum = i + j;
            Console.WriteLine(sum);

            // string? myString = ""; // string is already nullable so ? has no meaning

            #endregion

            #region Overloading Operators
            City city1 = new City();
            city1.Area = 10;
            city1.Population = 1000;
            City city2 = new City();
            city2.Area = 20;
            city2.Population = 2000;
            City city3 = city1 + city2;
            Console.WriteLine(city3.Area + "|" + city3.Population);
            #endregion

            Console.ReadLine();
        }
    }
    class City
    {
        public int Area { get; set; }
        public int Population { get; set; }

        public static City operator + (City A, City B)
        {
            City myCity = new City();
            myCity.Area = A.Area + B.Area;
            myCity.Population = A.Population + B.Population;

            return myCity;
        }
    }
}
