using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int actualCapacity = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int quantityOFWater = int.Parse(Console.ReadLine());
                actualCapacity += quantityOFWater;

                if (actualCapacity <= CAPACITY)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                    actualCapacity -= quantityOFWater;

                }


            }
            Console.WriteLine(actualCapacity);






        }
    }
}
