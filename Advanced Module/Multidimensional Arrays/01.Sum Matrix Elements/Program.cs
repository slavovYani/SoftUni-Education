using System;
using System.Linq;

namespace _01.Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] currentArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentArr[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
