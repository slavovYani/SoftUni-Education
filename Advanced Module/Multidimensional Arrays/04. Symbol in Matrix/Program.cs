using System;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfSquareMatrix;
            int cols = sizeOfSquareMatrix;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string current = Console.ReadLine();
                char[] currCol = current.ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currCol[col];
                }
            }

            char specialSymbol = char.Parse(Console.ReadLine());


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == specialSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{specialSymbol} does not occur in the matrix");
        }
    }
}
