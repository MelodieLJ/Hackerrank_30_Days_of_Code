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
            int entries = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            for (int i = 0; i < entries; i++)
            {
                var entry = Console.ReadLine().Split(' ');
                string name = entry[0];
                int number = Convert.ToInt32(entry[1]);
                phoneBook.Add(name, number);
            }

            for (int i = 0; i < entries; i++)
            {
                var query = Console.ReadLine();
                if (phoneBook.ContainsKey(query))
                {
                    var phone = phoneBook[query];
                    Console.WriteLine($"{query} = {phone}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}