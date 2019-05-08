using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LearningCsharp
{
    class MyRegex
    {
        static void Main(string[] args)
        {
            #region Example 1
            string text = "How to create (999)4567-123 the code syntax for 1/1/2018 simple programming statements " +
                "www.url.net using C# language, and recognize syntax F# errors using 15/12/2008 the Visual Studio " +
                "IDE. 1234 www.domain.com (800)2323-111 are here in 12.5.2001 and 18.11.2008";

            //string regex = @"\w+\."; // any alphanumeric that is followed by a . <dot>
            //string regex = @"\w+\s"; // any alphanumeric that is followed by space
            //string regex = @"(\d+/){2}\d+"; // dates 15/12/2008 1/1/2018
            //string regex = @"\d+"; //any digit
            //string regex = @"rec\w+"; // recognize
            //string regex = @"\w+23\w*"; // 123 1234 2323
            //string regex = @"\(\w{3}\)"; //(800) (900)
            //string regex = @"www\.\w+\.\w+"; // www.domain.com
            string regex = @"\d+\.\d+\.\d+";

            Regex obj = new Regex(regex);
            MatchCollection matchWords = obj.Matches(text);

            foreach (var word in matchWords)
            {
                Console.WriteLine(word);
            }

            #endregion

            #region Example 3
            string pattern = ":(.*?):";
            string lookup = "--:text in here:--";
            // Instanciate your regex object and pass a pattern to it
            Regex rgxLookup = new Regex(pattern, RegexOptions.Singleline, TimeSpan.FromSeconds(1));
            // Get the match from your regex-object
            Match mLookup = rgxLookup.Match(lookup);
            // The group-index 0 always covers the full pattern.
            // Matches inside parentheses will be accessed through the index 1 and above.
            string found = mLookup.Groups[1].Value;
            Console.WriteLine(found);
            #endregion

            Console.ReadLine();
        }
    }
}
