using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] inputInNumber = Array.ConvertAll(input, int.Parse);
            int[] condensed = new int[inputInNumber.Length - 1];

            while (inputInNumber.Length>1)
            {
                for (int i = 0; i < inputInNumber.Length-1; i++)
                {
                 condensed[i] = inputInNumber[i] + inputInNumber[i + 1];

                    if (i==inputInNumber.Length-2)
                    {
                    inputInNumber = condensed;
                    condensed = new int[inputInNumber.Length - 1];
                    }

                }

            }
            Console.WriteLine(inputInNumber[0]);
        }
    }
}
