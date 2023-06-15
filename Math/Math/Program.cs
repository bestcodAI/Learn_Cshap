using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
            // 😛 The Math.Max(x,y) method can be used to find the highest value of x and y.
            //int x = 5;
            // int y = 10;
            //Console.Write(Math.Max(x , y));
            //The Math.Min(x,y) method can be used to find the lowest value of of x and y:
            //int x = 45; int y = 89;
            //Console.WriteLine(Math.Min(x, y));
            //The Math.Sqrt(x) method returns the square root of x:
            //int x = 43;
            //Console.WriteLine(Math.Sqrt(x)); 
            // The Math.Abs(x) method returns the absolute (positive) value of x:
            //double x = -4.7D;
            //Console.WriteLine(Math.Abs(x));
            //Math.Round() rounds a number to the nearest whole number:
            float number = 9.99F;
            Console.WriteLine(Math.Round(number));
            Console.ReadKey();

        }
    }
}
