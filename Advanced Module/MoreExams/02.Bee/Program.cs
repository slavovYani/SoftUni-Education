using System;
using System.Transactions;

namespace _02.Bee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int pollinatedFlowers = 0;
            int[] beePosition = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'B')
                    {
                        beePosition = new int[2] { row, col };
                    }
                }
            }

            bool beeIsLost = false;
            string command;
            while (!beeIsLost && (command = Console.ReadLine()) != "End")
            {
                matrix[beePosition[0], beePosition[1]] = '.';

                switch (command)
                {
                    case "up":

                        if (CheckIfBeeIsOut(beePosition[0], sizeOfMatrix))
                        {
                            Console.WriteLine($"The bee got lost!");
                            beeIsLost = true;
                            break;
                        }
                        else
                        {

                            beePosition[0]--;


                        }




                        if (matrix[beePosition[0], beePosition[1]] == 'O')
                        {
                            matrix[beePosition[0], beePosition[1]] = '.';


                            beePosition[0]--;

                        }

                        if (matrix[beePosition[0], beePosition[1]] == 'f')
                        {
                            pollinatedFlowers++;


                        }

                        break;

                    case "down":

                        if (CheckIfBeeIsOutDown(beePosition[0], sizeOfMatrix))
                        {
                            Console.WriteLine($"The bee got lost!");
                            beeIsLost = true;
                            break;
                        }
                        else
                        {

                            beePosition[0]++;

                        }



                        if (matrix[beePosition[0], beePosition[1]] == 'O')
                        {

                            matrix[beePosition[0], beePosition[1]] = '.';

                            beePosition[0]++;


                        }

                        if (matrix[beePosition[0], beePosition[1]] == 'f')
                        {
                            pollinatedFlowers++;


                        }
                        break;

                    case "left":

                        if (CheckIfBeeIsOut(beePosition[1],sizeOfMatrix))
                        {
                            Console.WriteLine($"The bee got lost!");
                            beeIsLost = true;
                            break;
                        }
                        else
                        {

                            beePosition[1]--;

                        }



                        if (matrix[beePosition[0], beePosition[1]] == 'O')
                        {

                            matrix[beePosition[0], beePosition[1]] = '.';


                            beePosition[1]--;


                        }

                        if (matrix[beePosition[0], beePosition[1]] == 'f')
                        {
                            pollinatedFlowers++;


                        }

                        break;

                    case "right":

                        if (CheckIfBeeIsOutDown(beePosition[1], sizeOfMatrix))
                        {
                            Console.WriteLine($"The bee got lost!");
                            beeIsLost = true;
                            break;
                        }
                        else
                        {

                            beePosition[1]++;

                        }


                        if (matrix[beePosition[0], beePosition[1]] == 'O')
                        {

                            matrix[beePosition[0], beePosition[1]] = '.';


                            beePosition[1]++;

                        }

                        if (matrix[beePosition[0], beePosition[1]] == 'f')
                        {
                            pollinatedFlowers++;


                        }
                        break;

                }
                


            }



           

            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");

            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                matrix[beePosition[0], beePosition[1]] = 'B';
               

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }



        }

        private static bool CheckIfBeeIsOutDown(int beePosition, int sizeOfMatrix)
        {
            if (beePosition == 0 || beePosition == sizeOfMatrix-1)
            {
                return true;
            }

            return false;
        }

        private static bool CheckIfBeeIsOut(int beePosition, int sizeOfMatrix)
        {
            if (beePosition == 0 || beePosition== sizeOfMatrix-1)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
