using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Arrays
{
    //Challenge: Reverse an Array
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');

            int[] arr = Array.ConvertAll(temp, Int32.Parse);

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}