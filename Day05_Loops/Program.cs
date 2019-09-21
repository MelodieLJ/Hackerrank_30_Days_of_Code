using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Loops
{
    class Program
    {
        //Challenge: Given an integer, n, print its first 10 multiples. Each multiple n x i(where 1 < i < 10) should be printed on a new line in the form: n x i = result.
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                //int result = i * n;
                Console.WriteLine($"{n} x {i} = {i * n}");
            }
        }
    }
}
