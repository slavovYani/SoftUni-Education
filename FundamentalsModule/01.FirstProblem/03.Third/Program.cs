using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Third
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> priceRatings = Console.ReadLine().Split(",").Select(long.Parse).ToList();
            int entryPosition = int.Parse(Console.ReadLine());
            string typeOfElement = Console.ReadLine();
            long sumOfLeft = 0;
            long sumOfRight = 0;
            long entryPositionValue = priceRatings[entryPosition];

            //if (entryPosition>=1 & entryPosition<=priceRatings.Count-2)
            //{ 
            
                for (int i = entryPosition-1; i >= 0; i--)
                {
                    if (typeOfElement=="cheap" & priceRatings[i]<entryPositionValue)
                    {
                        
                        sumOfLeft += priceRatings[i];

                       

                    }
                    else if (typeOfElement=="expensive" & priceRatings[i]>= entryPositionValue)
                    {
                        sumOfLeft += priceRatings[i];
                        

                    }
                }

                for (int i = entryPosition+1; i < priceRatings.Count; i++)
                {
                    if (typeOfElement == "cheap" & priceRatings[i] < entryPositionValue)
                    {

                        sumOfRight += priceRatings[i];

                        

                    }
                    else if (typeOfElement == "expensive" & priceRatings[i] >= entryPositionValue)
                    {

                        sumOfRight += priceRatings[i];
                        

                    }
                }



                if (sumOfLeft>sumOfRight)
                {

                Console.WriteLine($"Left - {sumOfLeft}");
                }
                else if(sumOfLeft<sumOfRight)
                {
                    Console.WriteLine($"Right - {sumOfRight}");

                }
                else
                {
                  Console.WriteLine($"Left - {sumOfLeft}");

                }




            //}
        }
    }
}
