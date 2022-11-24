using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape square = new Square();

            Console.WriteLine(square.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
