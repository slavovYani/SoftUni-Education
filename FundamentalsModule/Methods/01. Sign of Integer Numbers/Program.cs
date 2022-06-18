using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            TypeOfNumber(int.Parse(Console.ReadLine()));

            
        }

        static void TypeOfNumber(int singleNumber)
        {
            switch (singleNumber)
            {
                case < 0:
                    Console.WriteLine($"The number {singleNumber} is negative.");
                    break;
                case 0:
                    Console.WriteLine($"The number {singleNumber} is zero.");
                    break;
                case > 0:
                    Console.WriteLine($"The number {singleNumber} is positive.");
                    break;

            }
        }
    }
}
