using System;
using System.Linq;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sizeOfSquareMatrix = byte.Parse(Console.ReadLine());
            byte rows = sizeOfSquareMatrix;
            byte cols = sizeOfSquareMatrix;
            char[,] matrix = new char[rows, cols];
            bool isElectriced = false;
            int holeCounter = 0;
            int rodCounter = 0;

            int[] startPosition = new int[2];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'V')
                    {
                        startPosition = new int[] { row, col };
                    }

                }

            }

            string command = Console.ReadLine();


            while (command != "End")
            {
                if (command == "up")
                {
                    if (startPosition[0] - 1 >= 0)
                    {
                        

                        if (matrix[startPosition[0] - 1, startPosition[1]] == 'C')
                        {
                            isElectriced = true;
                            matrix[startPosition[0], startPosition[1]] = '*';
                            holeCounter++;
                            matrix[startPosition[0] - 1, startPosition[1]] = 'E';
                            startPosition[0] = startPosition[0] - 1;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {++holeCounter} hole(s).");

                            break;
                        }
                        else if (matrix[startPosition[0] - 1, startPosition[1]] == 'R')
                        {
                            
                            rodCounter++;
                            Console.WriteLine($"Vanko hit a rod!");

                        }
                        else if (matrix[startPosition[0] - 1, startPosition[1]] == '-')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[0] = startPosition[0] - 1;

                            matrix[startPosition[0], startPosition[1]] = 'V';

                            holeCounter++;
                        }
                        else if (matrix[startPosition[0] - 1, startPosition[1]] == '*')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[0] = startPosition[0] - 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{startPosition[0]}, {startPosition[1]}]!");
                        }
                    }
                }
                else if (command == "down")
                {
                    if (startPosition[0] + 1 < rows)
                    {

                        if (matrix[startPosition[0] + 1, startPosition[1]] == 'C')
                        {
                            isElectriced = true;

                            matrix[startPosition[0], startPosition[1]] = '*';
                           
                            matrix[startPosition[0] + 1, startPosition[1]] = 'E';
                            startPosition[0] = startPosition[0] + 1;
                            holeCounter++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {++holeCounter} hole(s).");

                            break;
                        }
                        else if (matrix[startPosition[0] + 1, startPosition[1]] == 'R')
                        {
                            rodCounter++;
                            

                            Console.WriteLine($"Vanko hit a rod!");

                        }
                        else if (matrix[startPosition[0] + 1, startPosition[1]] == '-')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[0] = startPosition[0] + 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';


                            holeCounter++;
                        }
                        else if (matrix[startPosition[0] + 1, startPosition[1]] == '*')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[0] = startPosition[0] + 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{startPosition[0]}, {startPosition[1]}]!");

                        }
                    }

                }
                else if (command == "left")
                {
                    if (startPosition[1] - 1 >= 0)
                    {

                        if (matrix[startPosition[0], startPosition[1] - 1] == 'C')
                        {
                            isElectriced = true;

                            matrix[startPosition[0], startPosition[1]] = '*';
                           
                            matrix[startPosition[0], startPosition[1] - 1] = 'E';
                            startPosition[1] = startPosition[1] - 1;
                            holeCounter++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {++holeCounter} hole(s).");

                            break;
                        }
                        else if (matrix[startPosition[0], startPosition[1] - 1] == 'R')
                        {
                            
                            rodCounter++;

                            Console.WriteLine($"Vanko hit a rod!");

                        }
                        else if (matrix[startPosition[0], startPosition[1] - 1] == '-')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[1] = startPosition[1] - 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';


                            holeCounter++;
                        }
                        else if (matrix[startPosition[0], startPosition[1] - 1] == '*')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[1] = startPosition[1] - 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';


                            Console.WriteLine($"The wall is already destroyed at position [{startPosition[0]}, {startPosition[1]}]!");

                        }
                    }

                }
                else if (command == "right")
                {
                    if (startPosition[1] + 1 < cols)
                    {

                        if (matrix[startPosition[0], startPosition[1] + 1] == 'C')
                        {
                            isElectriced = true;

                            matrix[startPosition[0], startPosition[1]] = '*';
                          
                            matrix[startPosition[0], startPosition[1] + 1] = 'E';
                            startPosition[1] = startPosition[1] + 1;
                            holeCounter++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {++holeCounter} hole(s).");

                            break;
                        }
                        else if (matrix[startPosition[0], startPosition[1] + 1] == 'R')
                        {
                            
                            rodCounter++;
                            Console.WriteLine($"Vanko hit a rod!");

                        }
                        else if (matrix[startPosition[0], startPosition[1] + 1] == '-')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[1] = startPosition[1] + 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';

                            holeCounter++;
                        }
                        else if (matrix[startPosition[0], startPosition[1] + 1] == '*')
                        {
                            matrix[startPosition[0], startPosition[1]] = '*';

                            startPosition[1] = startPosition[1] + 1;
                            matrix[startPosition[0], startPosition[1]] = 'V';

                            Console.WriteLine($"The wall is already destroyed at position [{startPosition[0]}, {startPosition[1]}]!");

                        }

                    }
                }


                command = Console.ReadLine();
            }

           

            if (!isElectriced)
            {
                Console.WriteLine($"Vanko managed to make {++holeCounter} hole(s) and he hit only {rodCounter} rod(s).");
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j  = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
           




        }
    }
}
