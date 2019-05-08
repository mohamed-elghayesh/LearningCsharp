using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class MyClass
    {
        public delegate void LogHandler(string message);

        public void Process(LogHandler logHandler)
        {
            logHandler("Process() begins");
            logHandler("Process() ends");
        }
    }

    // The FileLogger class merely encapsulates the file I/O
    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;
        // Constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }
        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }
        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger("process.log"); // has the target method
            MyClass myClass = new MyClass(); // has the caller method(delegate)

            // Create an instance of the delegate, pointing to the Logger()
            MyClass.LogHandler myLoggerDelegate = new MyClass.LogHandler(fl.Logger);
            myClass.Process(myLoggerDelegate);
            fl.Close();

            Console.ReadLine();
        }
    }
}
