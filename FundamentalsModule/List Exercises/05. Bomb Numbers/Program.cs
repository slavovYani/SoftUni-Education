using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> combinationOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int[] specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int bombNumber = specialNumbers[0];
            //int powerOfNumber = specialNumbers[1];

            //bool containsSpecialNumber = combinationOfNumbers.Contains(bombNumber);

            //while (containsSpecialNumber = combinationOfNumbers.Contains(bombNumber))
            //{
            //    int indexOfBombNum = combinationOfNumbers.IndexOf(bombNumber);

            //    if (combinationOfNumbers.Count - 1 - indexOfBombNum < powerOfNumber)
            //    {
            //        combinationOfNumbers.RemoveRange(indexOfBombNum, (combinationOfNumbers.Count) - indexOfBombNum);

            //    }
            //    else
            //    {
            //        combinationOfNumbers.RemoveRange(indexOfBombNum, powerOfNumber + 1);
            //    }

            //    if (indexOfBombNum - powerOfNumber < 0)
            //    {
            //        combinationOfNumbers.RemoveRange(0, (combinationOfNumbers.Count - powerOfNumber) - 1);
            //    }
            //    else
            //    {
            //        combinationOfNumbers.RemoveRange(indexOfBombNum - powerOfNumber, powerOfNumber);

            //    }


            //}


            //Console.WriteLine(combinationOfNumbers.Sum());

            //Working option:

            List<int> numbersToCount = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] numberAndPower = Console.ReadLine().Split();

            int numberToRemove = int.Parse(numberAndPower[0]);
            int powerNumber = int.Parse(numberAndPower[1]);


            for (int i = 0; i < numbersToCount.Count; i++)
            {
                if (numbersToCount[i] == numberToRemove)
                {
                    if (i - powerNumber < 0 || i + powerNumber >= numbersToCount.Count)
                    {
                        if (i - powerNumber < 0 && i + powerNumber < numbersToCount.Count)
                        {
                            numbersToCount.RemoveRange(0, i + powerNumber + 1);
                        }

                        else if (i - powerNumber >= 0 && i + powerNumber >= numbersToCount.Count)
                        {
                            numbersToCount.RemoveRange(i - powerNumber, numbersToCount.Count - i + powerNumber);
                        }

                        else if (i - powerNumber < 0 && i + powerNumber >= numbersToCount.Count)
                        {
                            numbersToCount.RemoveRange(0, numbersToCount.Count);
                        }

                    }
                    else
                    {
                        int countOfNumbersToDel = powerNumber * 2 + 1;
                        numbersToCount.RemoveRange(i - powerNumber, countOfNumbersToDel);
                    }
                    i = -1;
                }
            }
            Console.WriteLine(numbersToCount.Sum());



        }


    }
}