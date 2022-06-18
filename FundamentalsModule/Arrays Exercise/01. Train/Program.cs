using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagons[i];
            }
            Console.WriteLine(String.Join(" ", peopleInWagons));
            Console.WriteLine(sum);
        }

    }
}
