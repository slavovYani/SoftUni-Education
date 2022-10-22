using System;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            string racingNumber = Console.ReadLine();

            int raceCarRow = 0;
            int raceCarCol = 0;

            int trackedKM = 0;

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            string input = Console.ReadLine();

            while (input != "End")
            {
                raceCarRow = MoveRow(raceCarRow, input);
                raceCarCol = MoveCol(raceCarCol, input);

                if (matrix[raceCarRow, raceCarCol] == '.')
                {
                    // mark previous position wiht '.' ?


                    trackedKM += 10;
                }

                if (matrix[raceCarRow, raceCarCol] == 'T')
                {
                    matrix[raceCarRow, raceCarCol] = '.';

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {

                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row, col] == 'T')
                            {
                                raceCarRow = row;
                                raceCarCol = col;

                                matrix[row, col] = '.';
                            }
                        }
                    }

                    trackedKM += 30;

                }

                if (matrix[raceCarRow, raceCarCol] == 'F')
                {
                    trackedKM += 10;

                    Console.WriteLine($"Racing car {racingNumber} finished the stage!");

                    break;
                }



                input = Console.ReadLine();
            }

            matrix[raceCarRow, raceCarCol] = 'C';     //here also not sure or in While


            if (input == "End")
            {
                Console.WriteLine($"Racing car {racingNumber} DNF.");

            }

            Console.WriteLine($"Distance covered {trackedKM} km.");




            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();


            }


        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
    }
}
