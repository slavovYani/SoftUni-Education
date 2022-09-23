using System;
using System.Linq;
using System.Text;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            string snakeWord = Console.ReadLine();
            int snakeIndex = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                if (row % 2 != 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (snakeIndex == snakeWord.Length)
                        {
                            snakeIndex = 0;

                        }
                        matrix[row, col] = snakeWord[snakeIndex];
                        snakeIndex++;

                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        if (snakeIndex == snakeWord.Length)
                        {
                            snakeIndex = 0;

                        }
                        matrix[row, col] = snakeWord[snakeIndex];
                        snakeIndex++;
                    }

                }




            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();

            }
        }

    }
}
