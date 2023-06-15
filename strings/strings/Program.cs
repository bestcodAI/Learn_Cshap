using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * String are used for string text.
             * A string variable contains a collection of characters surrounded by double qoutes
             * 🐱‍💻🐱‍💻🐱‍💻🐱‍💻🐱‍💻
             */
            // Create a variable of type string and assign it a value :
            //string greeting = "Hello";
            //Console.WriteLine(greeting + " My name is Chamnan");
            // A string variable can contain many words, if you want
            //string greeting2 = "Nice to meet you";
            //Console.WriteLine(greeting2);
            /*
             * A string in C# is actually an object, which contain properties and method that can perform contain operations on strings. For 
             * Example, the length of a strig can be found with the Length property.
             */
            // string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the string is : " + txt.Length);
            /*
             * Other Methods
             * There are many string method avariable , for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase
             */
            //string txt = "Hello world!";
            // using uppercase letters
            //Console.WriteLine(txt.ToUpper());
            // using lowercase letters
            //Console.WriteLine(txt.ToLower());
            /* String concatenation
             * The + operator can be used between strings to combine them. this is called concatenation
             */
            //string firstName = "Chou";
            //string lastName = "Chamnan";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);
            // 😍 Note that we have added a space after "Chou" to create a space between firstName and lastName on print
            // You can also use the string.Concat() and method to concatenate two strings:
            //string fName = "Chou ";
            //string lName = "Chamnan";
            //string FullName = string.Concat(fName, lName);
            //Console.WriteLine("we are using concate method :" + FullName);
            /*
             * Adding Numbers and String
             * Warning!
             * C# uses the + operator for both addition and concatenation.
             * Remember: Numbers are added. String are concatenated.
             */
            // if you add two numbers , the result will be a number
            //int x = 32;
            //int y = 67;
            //int z = x + y;
            //Console.WriteLine(z); // z will be 30 (an integer/number)
            //If you add two strings, the result will be a string concatenation
            //string x = "10";
            //string y = "20";
            //string z = x + y;
            //or using string.Concat() method 
            // string z = string.Concat(x, y);
            //Console.WriteLine(z); // z will be 1020 (a string)  
            Console.ReadKey();
        }
    }
}
