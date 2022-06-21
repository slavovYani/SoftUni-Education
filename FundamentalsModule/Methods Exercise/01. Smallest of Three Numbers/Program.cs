using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallestNumber = _Smallest_of_Three_Numbers(firstNumber,secondNumber,thirdNumber);
            Console.WriteLine(smallestNumber);
        }

        private static int _Smallest_of_Three_Numbers(int a, int b, int c)
        {
            int smallestNumber = Math.Min(a, Math.Min(b, c));
            return smallestNumber;
        }
    }
}
