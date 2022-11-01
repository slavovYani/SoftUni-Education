using System;

namespace Restaurant
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Cake cake = new Cake("Sofle");

            Console.WriteLine(cake.Grams);

            Coffee coffe = new Coffee("Illy", 555);

            Console.WriteLine(coffe.Price);
        }
    }
}
