using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? "); // You can add as many WriteLine() methods as you want. Note that it will add a new line for each method
            Console.WriteLine("How are you today? ");
            Console.Write("My name is chamnan "); //The only difference is that it does not insert a new line at the end of the output:
            Console.Write("and You");
            Console.ReadKey(); // ReadKey() Obtains the next character or function key pressed by the user
        }
    }
}
