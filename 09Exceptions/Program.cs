using System;
using System.IO;

namespace LearningCsharp
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            // allowed with double not int
            double d = 0;
            Console.WriteLine(d);
            Console.WriteLine(1 / d);
            Console.WriteLine(-1 / d);
            Console.WriteLine(d / d);

            try
            {
                int n = 0;
                Console.WriteLine(n);
                //Console.WriteLine(1 / n);
                //Console.WriteLine(-1 / n);
                Console.WriteLine(n / n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // file io exception
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"..\..\except.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Console.ReadLine();
        }
    }
}
