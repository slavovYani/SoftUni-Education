using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int line = int.Parse(Console.ReadLine());
                box.Items.Add(line);
            }

            Console.WriteLine(box);
        }
    }
}
