using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte priceOfBullet = byte.Parse(Console.ReadLine());
            short sizeOfGunBarrel = short.Parse(Console.ReadLine());

            byte[] bullets = Console.ReadLine().Split().Select(byte.Parse).ToArray();
            byte[] locks = Console.ReadLine().Split().Select(byte.Parse).ToArray();

            int valueIntel = int.Parse(Console.ReadLine());

            Stack<byte> bulletsStack = new Stack<byte>(bullets);
            Queue<byte> locksStack = new Queue<byte>(locks);

            byte shootsCounter = 0;
            byte barrelCounter = 0;

            while (bulletsStack.Any() && locksStack.Any())
            {
                shootsCounter++;
                barrelCounter++;

                if (bulletsStack.Peek() <= locksStack.Peek())
                {
                    bulletsStack.Pop();
                    locksStack.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bulletsStack.Pop();
                    Console.WriteLine("Ping!");
                }

                if (barrelCounter==sizeOfGunBarrel && bulletsStack.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    barrelCounter = 0;
                    
                }

            }

            int moneyEarned = valueIntel - (shootsCounter * priceOfBullet);
            if (locksStack.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksStack.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
            }


        }
    }
}
