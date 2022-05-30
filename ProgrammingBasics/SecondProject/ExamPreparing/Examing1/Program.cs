using System;

namespace Examing1
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = string.Empty;
            double totalTickets = 0;
            double standardTicketsTotal = 0;
            double studentTicketsTotal = 0;
            double kidsTicketsTotal = 0;

            while ((movie=Console.ReadLine())!= "Finish")
            {
            double standardTickets = 0;
            double studentTickets = 0;
            double kidTickets = 0;
            double totalTicketsForMovie = 0;
            double procentTotalTicketsForMovie = 0;

            int freeSeats = int.Parse(Console.ReadLine());
                string typeOfSeat = string.Empty;
                
                for (int i = 0; i < freeSeats && (typeOfSeat=Console.ReadLine())!= "End"; i++)
                {

                    switch (typeOfSeat)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;

                    }

                }
                standardTicketsTotal += standardTickets;
                studentTicketsTotal += studentTickets;
                kidsTicketsTotal += kidTickets;

               totalTicketsForMovie = standardTickets + studentTickets + kidTickets;

               procentTotalTicketsForMovie = totalTicketsForMovie / freeSeats * 100;

               Console.WriteLine($"{movie} - {procentTotalTicketsForMovie:f2}% full.");

                totalTickets += totalTicketsForMovie;
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTicketsTotal / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTicketsTotal/totalTickets)*100:f2}% standard tickets.");
            Console.WriteLine($"{(kidsTicketsTotal / totalTickets) * 100:f2}% kids tickets.");


        }
    }
}
