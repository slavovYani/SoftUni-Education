using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> ints = new Stack<int>(input);

            string[] command = Console.ReadLine().Split().ToArray();
            string mainCommand = command[0].ToLower();

            while (mainCommand != "end")
            {

                switch (mainCommand)
                {
                    case "add":
                        int secondNumber = int.Parse(command[2]);
                        int firstNumber = int.Parse(command[1]);
                        ints.Push(firstNumber);
                        ints.Push(secondNumber);
                        break;

                    case "remove":

                        int count = int.Parse(command[1]);
                        if (count <= ints.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ints.Pop();
                            }

                        }

                        break;

                }
                command = Console.ReadLine().Split().ToArray();
                mainCommand = command[0].ToLower();

            }

            Console.WriteLine("Sum: " +ints.Sum());

        }
    }
}
