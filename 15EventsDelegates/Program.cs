using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    /* ========= Publisher of the Event ============== */
    public class MyClass
    {
        // Define a delegate named LogHandler, which will encapsulate
        // any method that takes a string as the parameter and returns no value
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler LogEvent;

        // Instead of having the Process() function take a delegate
        // as a parameter, we've declared a LogEvent event. Call the Event,
        // using the OnXXXX Method, where XXXX is the name of the Event.
        public void Process()
        {
            OnLog("Process() begin");
            OnLog("Process() end");
        }

        // By Default, create an OnXXXX Method, to call the Event
        protected void OnLog(string message)
        {
            LogEvent(message);
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

    /* ========= Subscriber of the Event ============== */
    // It's now easier and cleaner to merely add instances
    // of the delegate to the event, instead of having to
    // manage things ourselves
    class Program
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger("process1.log");
            MyClass myClass = new MyClass();

            // Subscribe the Functions Logger and fl.Logger
            myClass.LogEvent += new MyClass.LogHandler(Logger);
            myClass.LogEvent += new MyClass.LogHandler(fl.Logger);
            //myClass.LogEvent -= new MyClass.LogHandler(Logger);

            // The Event will now be triggered in the Process() Method
            myClass.Process();

            fl.Close();

            Console.ReadLine();
        }
    }
}
