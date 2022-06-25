using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            
            while (true)
            {
              string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Add":
                        int addedWagon = int.Parse(command[1]);
                        numberOfWagons.Add(addedWagon);
                        break;
                    case "end":
                        Console.WriteLine(string.Join(" ",numberOfWagons));
                        return;
                        
                    default:
                        int addedPassenger = int.Parse(command[0]);
                        numberOfWagons =AddedPassengerInWagon(addedPassenger,maxCapacityOfWagon,numberOfWagons);
                        break;
                    
                }


            }
        }

        private static List<int> AddedPassengerInWagon(int passengersToAdd, int maxPassengersInWagon, List<int> numberOfWagons)
        {
            for (int i = 0; i < numberOfWagons.Count; i++)
            {
                if (numberOfWagons[i]+passengersToAdd<=maxPassengersInWagon)
                {
                    numberOfWagons.Insert(i,passengersToAdd+numberOfWagons[i]);
                    numberOfWagons.RemoveAt(i + 1);

                    break;
                }
            }
                    return numberOfWagons;
            
        }
    }
}
