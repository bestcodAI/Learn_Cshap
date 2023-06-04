using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type casting is when you assign a value of one data type to another type
             * in C# , there are two types of casting:
             * 👨‍💻 Implicit Casting(automatically) - converting a smaller type to a larger type size
             *    👨‍🎓 char -> int -> long -> float -> double 
             * 👨‍💻 Explicit casting(manually) - converting a larger type to a smaller type size 
             *    👨‍🎓 double -> float -> long -> int -> char
             */

            // Implicit casting is done automatically when passing  a smaller type to a bigger type size
            //int myNum = 59;
            //double myDouble = myNum; // Automatic casting : int to double
            // Console.WriteLine(myNum);
            // Console.WriteLine(myDouble);
            // Explicit casting must be done manually by placing the type in parentheses in front of the value
            //double myDouble = 45.78;
            //int myInt = (int) myDouble;
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myInt);
            // 👨‍🎓 Type conversion method 
            // 👨‍💻 It is also possible to convert data type explicitly by using build-in method,such as Convert.ToBooolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64 (long)
            int myInt = 10;
            double myDouble = 5.45;
            bool myBoolean = true;
            Console.WriteLine("Converted Integer to string : " + Convert.ToString(myInt)); // convert int  to string 
            Console.WriteLine("Converted Integer to double : " + Convert.ToDouble(myInt)); // convert int to double
            Console.WriteLine("Converted Double to Integer : " + Convert.ToInt32(myDouble)); // convert double to int
            Console.WriteLine("Converted Boolean to String : " + Convert.ToString(myBoolean)); // convert bool to string
            Console.ReadKey();

            /*
             * 👨‍🎓 Why Conversion?
             * ☝ Many time , there's no need for type conversion. But sometime you have to. Take a look at the next character, when working with user input, to see an example of this
             */
        }
    }
}
