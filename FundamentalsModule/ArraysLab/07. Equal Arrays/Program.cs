using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            int[] inputEqualNumber = Array.ConvertAll(firstInput, int.Parse);
            int sumOfOneEqualInput = 0;
            for (int i = 0; i < inputEqualNumber.Length; i++)
            {
            sumOfOneEqualInput += inputEqualNumber[i];

            }
           

            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] != secondInput[i])
                {

                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }
                Console.WriteLine($"Arrays are identical. Sum: {sumOfOneEqualInput}");
                        
        }
    }
}

