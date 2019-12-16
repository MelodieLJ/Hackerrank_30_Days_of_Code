using System;

namespace Day09_Recursion
{
    //Challenge: Write a factorial function that takes a positive integer, n as a parameter and prints the result of n! (n factorial).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }


        public static int Factorial(int n)
        {
            //Base Case: End
            if (n <= 1)
                return 1;
            //Recursive Case: Continue
            else
            {
                //3 * Factorial(2)
                //3 * 2 * Factorial(1)
                //return 3 * 2 * 1
                return n * Factorial(n - 1);
            }
        }
    }
}
