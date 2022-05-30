using System;

namespace ExamplesOfExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocations = int.Parse(Console.ReadLine());

            double averageGoldPerDayActual = 0;

            for (int i = 0; i < numberOfLocations; i++)
            {
                double goldPerDayActual = 0;

                double averageGoldPerDayExpected = double.Parse(Console.ReadLine());
                int numberOfDaysDigging = int.Parse(Console.ReadLine());

                for (int j = 0; j < numberOfDaysDigging; j++)
                {
                    goldPerDayActual += double.Parse(Console.ReadLine());

                }
                    averageGoldPerDayActual = goldPerDayActual / numberOfDaysDigging;

                if (averageGoldPerDayActual>=averageGoldPerDayExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDayActual:f2}.");
                }
                else
                {
                    double neededGold = averageGoldPerDayExpected - averageGoldPerDayActual;
                    Console.WriteLine($"You need {neededGold:f2} gold.");

                }
            }




        }
    }
}
