using System;

namespace Excersices01
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
            //2. Необходимо количество боя (в литри) - цяло число в интервала [1…100]
            //3. Количество разредител (в литри) - цяло число в интервала [1…30]
            //4. Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]

            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double naylonTotal = (naylon + 2) * 1.5;
            double paintTotal = (paint + (paint /10)*14.5);
            int thinnerTotal = thinner * 5;
            double bags = 0.4;
            double totalMaterials = naylonTotal + paintTotal + thinnerTotal + bags;
            double totalMaistors = (totalMaterials * 0.3) * hours;
            double total = totalMaterials + totalMaistors;

            Console.WriteLine(total);








        }
    }
}
