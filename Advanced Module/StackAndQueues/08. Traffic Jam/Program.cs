using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            int counterForCars = 0;

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {

                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            counterForCars++;

                        }

                    }


                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"{counterForCars} cars passed the crossroads.");

        }
    }
}
