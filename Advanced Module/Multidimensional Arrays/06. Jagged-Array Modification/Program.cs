using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[matrixRows][];


            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                int[] currentCol = Console.ReadLine().Split().Select(int.Parse).ToArray();



                jaggedMatrix[row] = currentCol;

            }
            string[] input = Console.ReadLine().Split();
            string command = input[0];

            while (command != "END")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row<0 || col<0 || row> jaggedMatrix.GetLength(0) - 1 || col > jaggedMatrix[row].Length - 1) /// check also here
                {
                    Console.WriteLine("Invalid coordinates");

                    
                }
                else
                {
                    switch (command)
                    {
                        case "Add":
                            jaggedMatrix[row][col] += value;
                            break;

                        case "Subtract":
                            jaggedMatrix[row][col] -= value;
                            break;

                    }
                    
                    
                }
                    input = Console.ReadLine().Split();
                    command = input[0];
            }

            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                Console.Write(String.Join(" ", jaggedMatrix[row]));
                Console.WriteLine();
            }
        }
    }
}
