using System;

namespace PractiseAfterExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            int totalHikers = 0;
            double musalaHikers = 0;
            double monblanHikers = 0;
            double kilimandjaroHiker = 0;
            double k2Hikers = 0;
            double everestHikers = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int hikersInGroup = int.Parse(Console.ReadLine());
                totalHikers += hikersInGroup;

                if (hikersInGroup <= 5)
                {
                    musalaHikers += hikersInGroup;
                }
                else if (hikersInGroup >= 6 && hikersInGroup <= 12)
                {
                    monblanHikers += hikersInGroup;
                }

                else if (hikersInGroup >= 13 && hikersInGroup <= 25)
                {
                    kilimandjaroHiker += hikersInGroup;
                }

                else if (hikersInGroup >= 26 && hikersInGroup <= 40)
                {
                    k2Hikers += hikersInGroup;
                }
                else
                {
                    everestHikers += hikersInGroup;
                }


            }
            Console.WriteLine($"{(musalaHikers / totalHikers) * 100:f2}%");
            Console.WriteLine($"{(monblanHikers / totalHikers) * 100:f2}%");
            Console.WriteLine($"{(kilimandjaroHiker / totalHikers) * 100:f2}%");
            Console.WriteLine($"{(k2Hikers / totalHikers) * 100:f2}%");
            Console.WriteLine($"{(everestHikers / totalHikers) * 100:f2}%");




        }
    }
}
