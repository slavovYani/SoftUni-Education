using System;

namespace WhileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsForDayAim = 10000;
            int totalSteps = 0;
            int stepsInDay= 0;

            while (stepsForDayAim>totalSteps)
            {
                string stepsInDayOrHome = Console.ReadLine();

                if (stepsInDayOrHome == "Going Home")
                {
                   stepsInDay = int.Parse(Console.ReadLine());
                    totalSteps += stepsInDay;
                    if (totalSteps < stepsForDayAim)
                    {
                        Console.WriteLine($"{stepsForDayAim - totalSteps} more steps to reach goal.");
                        return;
                    }
                    continue;
                        
                }
                else
                {
                stepsInDay = int.Parse(stepsInDayOrHome);

                }

                totalSteps += stepsInDay;

            }
            Console.WriteLine($"Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - stepsForDayAim} steps over the goal!");

        }
    }
}
