using System;


namespace FirstProjectCoding
{
    class RepaintingProject
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            double paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double naylonTotal = (naylon + 2) * 1.5;
            double paint10 = paint / 10;
            double paintTotal = (paint + paint10) * 14.5;
            int thinnerTotal = thinner * 5;
            double bags = 0.4;
            double totalMaterials = naylonTotal + paintTotal + thinnerTotal + bags;
            double totalMaistors = (totalMaterials * 0.3) * hours;
            double total = totalMaterials + totalMaistors;


            Console.WriteLine(total);







        }
    }
}
