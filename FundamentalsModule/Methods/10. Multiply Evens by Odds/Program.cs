using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a program that multiplies the sumof all even digits of a number by the sum of all odd digits of the same
            // number:
            //• Create a method called GetMultipleOfEvenAndOdds()
            //• Create a method GetSumOfEvenDigits()
            //• Create GetSumOfOddDigits()
            //• You may need to use Math.Abs() for negative numbers


            int number = int.Parse(Console.ReadLine());


           int sumOfEven = GetSumOfEvenDigits(number);
           int sumOfOdd= GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd);
            Console.WriteLine(result);




        }

        private static int GetMultipleOfEvenAndOdds(int sumOfEven,int sumOfOdd)
        {
            return sumOfOdd * sumOfEven;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            int eachNumber = 0;

            while (number != 0)
            {
                eachNumber = number % 10;

                if (eachNumber % 2 != 0)
                {
                    sumOfOddDigits += Math.Abs(eachNumber);
                }
                number /= 10;
            }

            return sumOfOddDigits;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            int eachNumber = 0;

            while (number!=0)
            {
                eachNumber = number % 10;

                if (eachNumber%2==0)
                {
                    sumOfEvenDigits += Math.Abs(eachNumber);
                }
                number /= 10;
            }
            
            return sumOfEvenDigits;

        }
    }
}
