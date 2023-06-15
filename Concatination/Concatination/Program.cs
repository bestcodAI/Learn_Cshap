using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Concatination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string  concatination
             * The + operation can be used between string to combine them . This is called concatination
            */
            // example 
            /* string firstName = "Chou";
             string lastName = "Chamnan";
             string fullName = firstName + " " + lastName;
             Console.WriteLine(fullName);*/
            /* Note that we have added a space after "Chou" to create a space between firstName and lastName on print.
             * You can also use the string.Concate() method to concatinate two strings:
             */
            /*string firstName = "Chou";
            string lastName = " Chamnan";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);*/
            /* adding Numbers and strings 
             * warning 
             * C# uses the + operation for both addition and concatination.
             * Remember: Numbers are added. String are concatenated. 
             */
            // If you add two numbers,the result will be a number:
            /*int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z); // it will be 30 (an integer/number)*/
            // If you add two strings, the result will be a string concatenation:
            /*string x = "10";
            string y = "20";
            string z = x + y;
            Console.WriteLine(z); // it will be 1020 (a string)*/
            Console.ReadKey();
        }
    }
}
