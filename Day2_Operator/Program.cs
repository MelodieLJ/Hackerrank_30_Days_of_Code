using System;

namespace Day2_Operator
{
    //Challenge: Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.

    class Program
    {
        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tax = (meal_cost * tax_percent) / 100;
            double tip = (meal_cost * tip_percent) / 100;
            double totalCost = meal_cost + tax + tip;
            // Round the total cost and output to console
            Console.WriteLine(Math.Round(totalCost));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            Solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
