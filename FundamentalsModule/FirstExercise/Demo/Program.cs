using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case <= 2:
                    break;
                case >2 and <=14:
                case >14 or 15:

                default:
                    Console.WriteLine("Error");
                    break;

            }

            Console.WriteLine(age==5? "good": "bad");
        }
    }
}
