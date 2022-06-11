using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWeek = int.Parse(Console.ReadLine());

            string[] dayOfWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

            if (numberOfWeek>=1 & numberOfWeek<=dayOfWeek.Length)
            {
            numberOfWeek--;
            Console.WriteLine(dayOfWeek[numberOfWeek]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
