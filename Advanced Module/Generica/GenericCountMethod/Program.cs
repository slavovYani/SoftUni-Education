using System;

namespace GenericCountMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < lines; i++)
            {
                box.Items.Add(double.Parse(Console.ReadLine()));
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(elementToCompare));
        }
    }
}
