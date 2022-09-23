using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            }


            for (int row = 0; row < jaggedArray.GetLength(0) - 1; row++)
            {

                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(n => n * 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(n => n * 2).ToArray();


                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(n => n / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(n => n / 2).ToArray();
                }

            }

            string[] command = Console.ReadLine().Split();
            

            while (command[0] != "End")
            {
                int row = 0;
                int col = 0;
                int value = 0;
                switch (command[0])
                {
                    case "Add":
                        row = int.Parse(command[1]);
                        col = int.Parse(command[2]);
                        value = int.Parse(command[3]);

                        if (row < jaggedArray.GetLength(0) && row >=0 && col < jaggedArray[row].Length&& col>=0)
                        {
                            jaggedArray[row][col] += value;
                        }

                        break;

                    case "Subtract":
                        row = int.Parse(command[1]);
                        col = int.Parse(command[2]);
                        value = int.Parse(command[3]);

                        if (row < jaggedArray.GetLength(0) && row>=0 && col < jaggedArray[row].Length&& col>=0)
                        {
                            jaggedArray[row][col] -= value;
                        }

                        break;

                }


                command = Console.ReadLine().Split();
            }


            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {

                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }
    }
}
