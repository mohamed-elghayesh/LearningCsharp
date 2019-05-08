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
            #region instantiating objects from classes and using instance method 
            // getting from constructor
            Cat myCat1 = new Cat();
            Console.WriteLine("Hello {1} Cat, your name is {0}", myCat1.Name, myCat1.Color);

            // Invoke instance method
            myCat1.SayMiau();
            
            // setting
            Cat myCat2 = new Cat("Tom", "Blue");
            Console.WriteLine("Hello {1} Cat, your name is {0}", myCat2.Name, myCat2.Color);

            // Invoke instance method
            myCat2.SayMiau();
            #endregion

            myCat1.Habitat = "Water";
            Console.WriteLine(myCat1.Activity());

            Console.ReadLine();
        }
    }

    
}
