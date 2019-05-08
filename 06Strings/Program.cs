using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCsharp
{
    class Strings
    {
        static void Main(string[] args)
        {
            // common string operations

            // formatting
            Console.WriteLine("This is a string.");
            Console.WriteLine("It is now {0:d} at {0:t}", DateTime.Now);

            string formatted = String.Format("This is {0} string{1}", "another", ".");
            Console.WriteLine(formatted);

            string cal = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(cal);

            // numbering systems
            Console.WriteLine(Convert.ToInt16("F", 16));
            Console.WriteLine(Convert.ToInt16("1001", 2));

            // null strings or whitespaced strings
            string testString = "\t"; // null, "", " ", "\t", "\n", "123456"
            Console.WriteLine(String.IsNullOrEmpty(testString)); // true
            Console.WriteLine(String.IsNullOrWhiteSpace(testString)); // false

            // string to array of char
            char[] a = cal.ToCharArray();
            Array.ForEach(a, el => Console.Write(el));
            Console.WriteLine("\n"+ a[3]);
            Console.WriteLine();

            System.Array.Reverse(a);
            foreach (var elem in a)
            {
                Console.Write(elem);
            }
            Console.WriteLine();

            // array of char to string
            string delimiter = ";";
            char[] charArray = new[] { 'a', 'b', 'c' };
            string inputString = String.Join(delimiter, charArray);
            Console.WriteLine(inputString);

            // string padding
            string something = "Foo";
            string paddedLeft = something.PadLeft(5); // paddedLeft = " Foo" (pads with spaces by default)
            Console.WriteLine(paddedLeft);

            string otherthing = "Foo";
            string paddedRight = otherthing.PadRight(6, '+'); // paddedRight = "Foo+++"
            Console.WriteLine(paddedRight);

            // Trimming strings
            string string1 = " Hello World! ";
            Console.WriteLine(string1.Trim()); // "Hello World!"

            string string2 = "{(Hi{!*";
            Console.WriteLine(string2.Trim('(', '*', '{')); // "Hi!"
            Console.WriteLine(string2.TrimStart('{')); // "(Hi*"
            Console.WriteLine(string2.TrimEnd('*')); // "{(Hi"

            // formatting int as string
            int intValue = 10;
            string zeroPaddedInteger = intValue.ToString("000"); // Output will be "010"
            Console.WriteLine(zeroPaddedInteger);
            string customFormat = intValue.ToString("Input value is 0"); // output will be "Input value is 10
            Console.WriteLine(customFormat);

            // formatting double as string
            double doubleValue = 10.456;
            string roundedDouble = doubleValue.ToString("0.00"); // output 10.46
            string integerPart = doubleValue.ToString("00"); // output 10
            string customDoubleFormat = doubleValue.ToString("Input value is 0.0"); // Input value is 10.5
            Console.WriteLine("************"+ roundedDouble);

            // formatting date as string
            DateTime currentDate = DateTime.Now; // {7/21/2016 7:23:15 PM}
            string dateTimeString = currentDate.ToString("dd-MM-yyyy HH:mm:ss"); // "21-07-2016 19:23:15"
            string dateOnlyString = currentDate.ToString("dd-MM-yyyy"); // "21-07-2016"
            string dateWithMonthInWords = currentDate.ToString("dd-MMMM-yyyy HH:mm:ss"); // "21-July-2016 19:23:15"
            Console.WriteLine(dateWithMonthInWords);

            // splitting a character
            string helloWorld = "Hello world, how is it going?";
            string[] parts1 = helloWorld.Split(',');
            Array.ForEach(parts1, part => Console.Write(part + " | "));

            Console.WriteLine();

            // splitting a string by a sub-string
            string str = "this--is--a--complete--sentence";
            string[] tokens = str.Split(new[] { "--" }, StringSplitOptions.None);
            Array.ForEach(tokens, tok => Console.Write(tok + " | "));

            Console.WriteLine();

            // getting substring
            string world = helloWorld.Substring(6); //world = "World, ..."
            string hello = helloWorld.Substring(0, 5); // hello = "Hello"
            Console.WriteLine(world);
            Console.WriteLine(hello);

            // find if a string starts with a word
            Console.WriteLine(helloWorld.StartsWith("Hello")); // true
            Console.WriteLine(helloWorld.StartsWith("Foo")); // false

            // find if a string contains a key-word
            Console.WriteLine(helloWorld.Contains("how")); // true

            // Enumerating a string, treating as a char[]
            Console.WriteLine(helloWorld[4]);  // o
            foreach (char ch in helloWorld)
            {
                Console.Write(ch + "|");
            }

            Console.WriteLine();

            // replacing strings
            Console.WriteLine(helloWorld.Replace("world", "universe"));
            Console.WriteLine(helloWorld.Replace("Hello", String.Empty));

            // Concatenating a string
            string first = "Hello ";
            string second = "World";
            string concat1 = first + second; // concat = "Hello World"
            string concat2 = String.Concat(first," ", second); // concat = "Hello World"
            string concat3 = $"{first} {second}"; // C# 6, concat = "Hello World"

            // String Builder
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString()); // "1 2 3 4 5 "

            // string escape sequence
            
            // The filename will be c:\myfile.txt in both cases
            string filename1 = "c:\\myfile.txt";
            string filename2 = @"c:\myfile.txt";

            // Quotes
            string text = "\"Hello World!\", said the quick brown fox.";
            string verbatimText = @"""Hello World!"", said the quick brown fox.";

            /*  string builder is reference type used when concat. arbiterary number of strings.
             *  while use value type string.concat() with concatenating fixed number of strings
             */
            StringBuilder sbText = new StringBuilder();
            sbText.Append("Hello World String Builder");
            StringBuilder text1 = sbText;
            StringBuilder text2 = sbText;

            text2.Append(" % changing!");
            Console.WriteLine(sbText);
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            Console.ReadLine();
        }
    }
}
