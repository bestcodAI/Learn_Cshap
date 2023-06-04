using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * The general rules for naming variable are: 
             * »»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»
             * 🤷‍ Name can contain letters, digits and the underscore character(_)
             * 🤷‍ Name must begin with a letter
             * 🤷‍ Name should start with a lowercase letter and it cannot contain whitespace
             * 🤷‍ Name should are case sensitive ("myVar" and "myvar" are different variables)
             * 🤷‍ Reserved words (like C# keywords , such as int or double) cannot be used as names
             * 
             */
            // Note: It is recommended to use descriptive names in order to create understandable and maintainable code
            // Good 
            int minutePerHour = 60;
            //Ok , but no so easy to understand what m actually is 
            int m = 60;
            Console.WriteLine("Declaring Good " + minutePerHour);
            Console.WriteLine("Declaring Not Good " + m);
            Console.ReadKey();
        }
    }
}
