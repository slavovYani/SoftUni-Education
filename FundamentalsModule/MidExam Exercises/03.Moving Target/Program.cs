using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> movingTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Shoot":
                        int indexForShoot = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        movingTargets = ShootingTarget(movingTargets,indexForShoot,power);
                        break;
                    case "Add":
                        int indexToAdd = int.Parse(command[1]);
                        int valueToAdd = int.Parse(command[2]);
                        movingTargets=AddValue(movingTargets, indexToAdd, valueToAdd);

                        break;
                    case "Strike":
                        int indexToStrike = int.Parse(command[1]);
                        int radiusToStrike = int.Parse(command[2]);
                        movingTargets = StrikeTarget(movingTargets, indexToStrike, radiusToStrike);

                        break;
                    case "End":
                        Console.WriteLine(string.Join("|",movingTargets));
                        return;

                }

            }
        }

        static List<int> StrikeTarget(List<int> targets, int index, int radius)
        {
            bool indexIsValid = index < targets.Count&index>=0;
            bool rangeIsNotValid = index - radius < 0 || index + radius > targets.Count - 1;

            if (indexIsValid&!rangeIsNotValid)
            {
                targets.RemoveRange(index - radius, radius * 2+1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            return targets;
        }

        static List<int> AddValue(List<int> targets, int index, int value)
        {
            bool indexIsValid = index < targets.Count&index>=0;

            if (indexIsValid)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
                
            }

            return targets;
        }

        static List<int> ShootingTarget(List<int> targets,int index, int power)
        {
            bool indexIsValid = index < targets.Count& index>=0;

            if (indexIsValid)
            {
                if (targets[index]<=power)
                {
                    targets.RemoveAt(index);
                }
                else
                {
                    int newValue = targets[index] - power;
                    targets.Insert(index, newValue);
                    targets.RemoveAt(index + 1);
                }
                if (targets.Contains(0))
                {
                    targets.Remove(0);
                }
            }
            return targets;

        }
    }
}
