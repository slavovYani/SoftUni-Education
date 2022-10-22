using System;

namespace GenerixBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                box.Items.Add(line);
            }

            Console.WriteLine(box);
        }
    }
}
