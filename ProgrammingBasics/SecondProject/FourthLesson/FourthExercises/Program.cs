using System;

namespace FourthExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLilly  = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int risingStep = 0;
            int SavedMoney = 0;
            int brotherMoney = ageLilly/2;
            double toysMoney = 0;
            int toysNumber = 0;



            for (ageLilly=ageLilly; 0 < ageLilly; ageLilly--)
            {
                
                if (ageLilly % 2 == 0)
                {
                    risingStep += 10;
                    SavedMoney += risingStep;

                }
                
                else if (ageLilly % 2 != 0)
                {
                    toysNumber++;
                    
                }
                

            }
                toysMoney = toysNumber * toyPrice;
                double totalMoney = toysMoney + SavedMoney-brotherMoney;

                if (totalMoney >= priceLaundry)
                {
                    Console.WriteLine($"Yes! {totalMoney - priceLaundry:f2}");
                }
                else
                {
                    Console.WriteLine($"No! {priceLaundry - totalMoney:f2}");
                }

            


            



        }
    }
}
