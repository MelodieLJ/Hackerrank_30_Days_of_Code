using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            // Read and save an integer, double, and String to your variables.
            int secondInt = Convert.ToInt32(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            string secondString = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + secondInt);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", d + secondDouble);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + secondString);
        }
    }
}
