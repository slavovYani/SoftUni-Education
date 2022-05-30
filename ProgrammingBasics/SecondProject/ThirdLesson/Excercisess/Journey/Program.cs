using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double summerBudget = 0;
            double winterBudget = 0;
            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    summerBudget = 0.3 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{place} - {summerBudget:f2}");
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    winterBudget = 0.7 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{place} - {winterBudget:f2}");
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    summerBudget = 0.4 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{place} - {summerBudget:f2}");
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    winterBudget = 0.8 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{place} - {winterBudget:f2}");
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer"|| season == "winter")
                {
                    place = "Hotel";
                    summerBudget = 0.9 * budget;
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{place} - {summerBudget:f2}");
                }
                
            }

        }
    }
}
