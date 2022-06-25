using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{

        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> movingTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "End")
                    {
                        break;
                    }

                    string[] tokens = command.Split();
                    string actions = tokens[0];

                    switch (actions)
                    {
                        case "Shoot":
                            Shoot(int.Parse(tokens[1]), int.Parse(tokens[2]), movingTargets);
                            break;
                        case "Add":
                            Add(int.Parse(tokens[1]), int.Parse(tokens[2]), movingTargets);
                            break;
                        case "Strike":
                            Strike(int.Parse(tokens[1]), int.Parse(tokens[2]), movingTargets);
                            break;
                    }
                }


                Console.WriteLine(string.Join("|", movingTargets));
            }


            static void Shoot(int index, int power, List<int> targets)
            {
                if (index < 0 || index > targets.Count - 1)
                {
                    return;
                }

                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }

            static void Add(int index, int value, List<int> targets)
            {
                if (index < 0 || index > targets.Count - 1)
                {
                    Console.WriteLine("Invalid placement!");

                    return;
                }

                targets.Insert(index, value);
            }

            static void Strike(int index, int radius, List<int> targets)
            {
                if (index - radius < 0 || index + radius > targets.Count - 1)
                {
                    Console.WriteLine("Strike missed!");

                    return;
                }

                targets.RemoveRange(index - radius, radius * 2 + 1);
            }
        }
    }
