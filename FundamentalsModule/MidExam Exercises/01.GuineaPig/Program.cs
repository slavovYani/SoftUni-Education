using System;

namespace _01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            //• On the first line – quantity food in kilograms - a floating - point number in the range[0.0…10000.0].
            //• On the second line – quantity hay in kilograms - a floating - point number in the range[0.0…10000.0].
            //• On the third line – quantity cover in kilograms - a floating - point number in the range[0.0…10000.0].
            //• On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0…10000.0].

            //Output

            //• If the food, the hay and the cover are enough, print:
            //            o "Everything is fine! Puppy is happy! Food: {excessFood}, Hay: {excessHay},
            //Cover: { excessCover}."
            //• If one of the things is not enough, print:
            //            o "Merry must go to the pet store!"


            double foodInGrams = double.Parse(Console.ReadLine())*1000;
            double hayInGrams = double.Parse(Console.ReadLine())*1000;
            double coverInGrams = double.Parse(Console.ReadLine()) * 1000;
            double puppyWeightInGrams = double.Parse(Console.ReadLine()) * 1000;

            double daylyFood = 300;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= daylyFood;

                if (i%2==0)
                {
                    double hayDosage = foodInGrams * 0.05;
                    hayInGrams -= hayDosage;
                }
                if (i%3==0)
                {
                    double coverDosage = puppyWeightInGrams / 3;
                    coverInGrams -= coverDosage;
                }

                if (foodInGrams<0 || hayInGrams<0 || coverInGrams<0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                
               
            }
                  Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams/1000:f2}, Hay: {hayInGrams/1000:f2}, Cover: {coverInGrams/1000:F2}.");

            
        }
    }
}
