using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());
           
            double pointsGiven = 0;
            double pointsCalculated = academyPoints;

            for (int i = 0; i < evaluators; i++)
            {
                 string evaluatorName = Console.ReadLine();
                 pointsGiven = double.Parse(Console.ReadLine());
                
                pointsCalculated +=  (evaluatorName.Length * pointsGiven/2) ;

                if (pointsCalculated >= 1250.5)
                { 
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsCalculated:f1}!");
                    return;
                }

            }

            double neededPoints = 1250.5 - pointsCalculated;


            if (pointsCalculated < 1250.5)
            {
                
                Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
            }

        }
    }
}
