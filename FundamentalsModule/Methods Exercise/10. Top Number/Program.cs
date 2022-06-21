using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                bool isDivisible = IsSumDivisible(i);
                bool isOddDigit = IsContainOddDigit(i);

                if (isDivisible && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSumDivisible(int numm)
        {
            bool isDivisible = false;
            int totalSum = 0;

            while (numm > 0)
            {
                int currentDigit = numm % 10;
                totalSum += currentDigit;
                numm /= 10;
            }

            if (totalSum % 8 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
        static bool IsContainOddDigit(int number)
        {
            bool isValid = false;

            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    isValid = true;
                    break;
                }
                number /= 10;
            }
            return isValid;
        }
    }

 }

