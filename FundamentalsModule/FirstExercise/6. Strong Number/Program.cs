using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int eachDigit = 0;
            int originalNumber = number;
            int totalSum = 0;

            while (number>0)
            {
            int sum = 1;
                eachDigit = number % 10;
                for (int i = eachDigit; i >1; i--)
                {
                    sum *= i;
                }

                totalSum += sum;
                
                number/=10;
            }

            Console.WriteLine(originalNumber==totalSum? "yes":"no");

        }
    }
}
