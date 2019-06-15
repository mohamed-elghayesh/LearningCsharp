using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Program
    {
        // using throw allows stack trace history
        // throw ex, ends the stack trace
        static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }

            Console.ReadLine();
        }

        static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void Method1()
        {
            try
            {
                throw new Exception("This is Method1 Excetion");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
