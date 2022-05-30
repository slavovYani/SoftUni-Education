using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int winnerPoints = 2000;
            int finalistPoints = 1200;
            int semiFinalistPoints = 720;

            int tournamentNumbers = int.Parse(Console.ReadLine());
            int startRanklistPoints = int.Parse(Console.ReadLine());
                    
            int totalPointsInitial = startRanklistPoints;
            double tournamentWinner = 0;

            for (int i = 0; i < tournamentNumbers; i++)
            {
               string reachedStage = Console.ReadLine();
                switch (reachedStage)
                {
                    case "W":
                        
                        totalPointsInitial += winnerPoints;
                        tournamentWinner++;
                        break;

                    case "F":
                        totalPointsInitial += finalistPoints;
                        break;

                    case "SF":
                        totalPointsInitial += semiFinalistPoints;
                        break;

                }
                  
            }
                
            Console.WriteLine($"Final points: {totalPointsInitial}");

            double averagePointsPerTournament = ((totalPointsInitial-startRanklistPoints) / tournamentNumbers);
            averagePointsPerTournament = Math.Floor(averagePointsPerTournament);
            Console.WriteLine($"Average points: {(averagePointsPerTournament)}");

            double procentOfWins = (tournamentWinner / tournamentNumbers) * 100;
            Console.WriteLine($"{procentOfWins:f2}%");
        }
    }
}
