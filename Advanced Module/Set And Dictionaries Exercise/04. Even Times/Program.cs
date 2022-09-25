using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOfLines = int.Parse(Console.ReadLine());
            //int counter = 1;
            //HashSet<int> numbers = new HashSet<int>();
            //int winNum = 0;
            //bool isValid = false;

            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    int currNum = int.Parse(Console.ReadLine());

            //    if (numbers.Contains(currNum))
            //    {
            //        counter++;
            //    }

            //    numbers.Add(currNum);

            //    if (counter%2==0)
            //    {
            //        winNum = currNum;
            //        counter--;
            //        isValid = true;
            //    }

            //}

            //if (isValid)
            //{
            //    Console.WriteLine(winNum);

            //}


            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);





        }
    }
}
