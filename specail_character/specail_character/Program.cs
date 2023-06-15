using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specail_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String -Specail characters
             * Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
             */
            //string txt = "We are the so-called" Vikings " from the north"; // it's error
            //Console.WriteLine(txt);
            /*The solution to avoid this problem, is to use the backslash escape character.
             The backslash (\) escape character turns special characters into string characters:
                Escape character       Result                  Description
                 \'                    '                     Single quote
                \"                     "                      double quote
               \\                     \                       Backslash
            The sequence \"  inserts a double quote in a string:
            */
            //string txt = "We are the so-called \"Vikings\" from the north.";
            //Console.WriteLine(txt);
            //The sequence \'  inserts a single quote in a string:
            //string txt = "It\'s alright";
            //Console.WriteLine(txt);
            //The sequence \\  inserts a single backslash in a string:
            //string txt = "The character \\ is called backslash.";
            //Console.WriteLine(txt);
            /* Other useful escape characters in C# are:
             *  Code          Result       
             *  \n            New Line
             *  \t            Tab
             *  \b            Backspace
             */
            //Console.WriteLine("Hello \n World");// using \n for New Line
            //Console.WriteLine("Hello \t Chamnan"); // using \t for tab
            //Console.WriteLine("Hello \b Backspace"); // Backspacce
            Console.ReadKey();
        }
    }
}
