using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < lines; i++)
            {
                int line = int.Parse(Console.ReadLine());

                box.List.Add(line);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(indexes);

            Console.WriteLine(box);
        }
    }
}
