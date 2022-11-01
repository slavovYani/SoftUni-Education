using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight knight = new BladeKnight("Yani", 50);

            Console.WriteLine(knight);
        }
    }
}