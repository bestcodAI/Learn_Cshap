using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * String Concatenation
             * The + operator can be used between strings to combine them. This is called concatenation
             */
            /*string firstName = "Chou";
            string lastName = "Chamnan";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            */
            /* Note that we have added a space after "Chou" to create a space between firstName and lastName on print
             * You can also use the string.Concat() Method to concatenate two strings
             */
            //string fName = "Jonh ";
            //string lName = "Doe";
            //string fullName = string.Concat(fName, lName);
            //Console.WriteLine(fullName);
            /*
             * Adding Numbers and strings 
             * Warning !
             * C# uses the + operator for both addition and concatenation
             * Remember:Numbers are added. String are concatenated.
             */
            // If you add two numbers, the result will be a number;
            Console.ReadKey();
        }
    }
}
