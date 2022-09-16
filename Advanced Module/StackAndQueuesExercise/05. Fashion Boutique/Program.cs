using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<byte> valuesOfClothes = new Stack<byte>(Console.ReadLine().
                Split().
                Select(byte.Parse).
                ToList());

            byte capacityOfRack = byte.Parse(Console.ReadLine());
            int sumOfClothes = 0;
            byte numbersOfRacks = 0;

            while (valuesOfClothes.Count>0)
            {
               byte currentClothe = valuesOfClothes.Peek();
                sumOfClothes+=currentClothe;

                if (sumOfClothes<capacityOfRack)
                {
                    valuesOfClothes.Pop();

                    if (valuesOfClothes.Count==0)
                    {
                        numbersOfRacks++;
                    }
                }
                else if (sumOfClothes==capacityOfRack)
                {
                    numbersOfRacks++;
                    sumOfClothes = 0;

                    valuesOfClothes.Pop();


                }
                else 
                {
                    sumOfClothes = valuesOfClothes.Pop();
                    numbersOfRacks++;

                    if (valuesOfClothes.Count==0)
                    {
                        numbersOfRacks++;

                    }

                }
                
            }
            Console.WriteLine(numbersOfRacks);
        }
    }
}
