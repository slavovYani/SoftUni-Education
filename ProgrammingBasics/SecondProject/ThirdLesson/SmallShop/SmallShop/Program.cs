using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProduct = Console.ReadLine();
            string cityName = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (cityName)
            {
                case "Sofia":
                    switch (typeOfProduct)
                    {
                        case "coffee":
                            Console.WriteLine(0.5 * quantity);
                            break;
                        case "water":
                            Console.WriteLine(0.8 * quantity);
                            break;
                        case "beer":
                            Console.WriteLine(1.2 * quantity);
                            break;
                        case "sweets":
                            Console.WriteLine(1.45 * quantity);
                            break;
                        case "peanuts":
                            Console.WriteLine(1.60 * quantity);
                            break;

                    }
                    break;
                         case "Plovdiv":
                    switch (typeOfProduct)
                    {
                        case "coffee":
                            Console.WriteLine(0.4 * quantity);
                            break;
                        case "water":
                            Console.WriteLine(0.7 * quantity);
                            break;
                        case "beer":
                            Console.WriteLine(1.15 * quantity);
                            break;
                        case "sweets":
                            Console.WriteLine(1.30 * quantity);
                            break;
                        case "peanuts":
                            Console.WriteLine(1.50 * quantity);
                            break;
                    }
                    break;
                        case "Varna":
                    switch (typeOfProduct)
                    {
                        case "coffee":
                            Console.WriteLine(0.45 * quantity);
                            break;
                        case "water":
                            Console.WriteLine(0.7 * quantity);
                            break;
                        case "beer":
                            Console.WriteLine(1.10 * quantity);
                            break;
                        case "sweets":
                            Console.WriteLine(1.35 * quantity);
                            break;
                        case "peanuts":
                            Console.WriteLine(1.55 * quantity);
                            break;
                    }
                    break;

            }


        }
    }
}
