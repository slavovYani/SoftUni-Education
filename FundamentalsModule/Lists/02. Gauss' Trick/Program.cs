using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int middleNumber = 0;
            
            for (int i = 0; i < number.Count-1; i++)
            {
                int result = number[i] + number[number.Count - (i+1)];
                Console.Write(result+" ");
                number.RemoveAt(i);
                number.RemoveAt(number.Count-1);
                i = -1;
            }

            if (number.Count!=0)
            {
                Console.Write(number[0]);
            }
            
        }
    }
}
