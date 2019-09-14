using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Class_vs_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of test cases
            int T = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());

                Person p = new Person(age);
                //First check if person is old
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();

            }
        }

        public class Person
        {
            //instance var
            public int age;

            public Person(int initialAge)
            {
                if (initialAge > 0)
                {
                    age = initialAge;
                }
                else
                {
                    age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }
            }

            //instance method
            public void amIOld()
            {
                if (age < 13)
                {
                    Console.WriteLine("You are young");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            //instance method
            public void yearPasses()
            {
                age++;
            }
        }
    }
}
