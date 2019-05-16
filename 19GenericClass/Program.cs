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
            // Use the generic type Test with an int type parameter.
            Test<int> test1 = new Test<int>(5);
            // Call the Write method.
            test1.Write();

            // Use the generic type Test with a string type parameter.
            Test<string> test2 = new Test<string>("cat");
            test2.Write();

            Console.ReadLine();
        }
    }

    class Test<T>
    {
        T _value; //inner field

        public Test(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
}
