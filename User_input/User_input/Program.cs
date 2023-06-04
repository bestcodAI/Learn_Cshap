using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Get User Input
             * 👩‍💻 You have already learned at Console.WriteLine() is used to input(print) values. Now we will use Console.ReadLine() to get user input.
             * ☝ In the following example , the users can input his or hers username, which is stored in the variable userName.Then we print the value of userName
             */

            // make a question 
            //Console.WriteLine("What is your name? ");
            // Type your username and press enter
            //Console.Write("Input Your Name: ");
            //Create variable name and get user input from keyboard and store it in the variable
            // string username = Console.ReadLine();
            // Print the value of the variable (name), which will display the input value   
            //Console.WriteLine("Hello " + username);
            /*
             * 💑User Input and Numbers
             * The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type , such as int.
             * the following program will cause an error.
             */
            Console.Write("Enter you old : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old");
            Console.ReadKey();
        }
    }
}
