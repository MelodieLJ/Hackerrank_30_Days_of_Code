using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Dictionaries_and_Maps
{
    //Challenge: Given n names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. You will then be given an unknown number of names to query your phone book for. For each name queried, print the associated entry from your phone book on a new line in the form name=phoneNumber; if an entry for name is not found, print Not found instead.

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
