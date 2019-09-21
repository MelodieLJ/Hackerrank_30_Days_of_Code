using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Review
{
    //Challenge: Given a string, print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                string first = string.Empty;
                string second = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        first += input[j].ToString();
                    }
                    else
                    {
                        second += input[j].ToString();
                    }

                }
                Console.WriteLine(first + " " + second);
            }


        }
    }
}
