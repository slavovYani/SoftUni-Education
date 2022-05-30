using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            int boatRentSpring = 3000;
            int boatRentSummer = 4200;
            int boatRentWinter = 2600;
            bool fishersEven = fishers % 2 == 0;
            


            switch (season)
            {
                case "Spring":
                    if (fishers <= 6)
                    {
                        double boatRentSpringNew = boatRentSpring - boatRentSpring * 0.1;
                        if (fishersEven)
                        {
                            boatRentSpringNew = boatRentSpringNew - boatRentSpringNew * 0.05;
                        }

                        if (boatRentSpringNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget-boatRentSpringNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSpringNew-budget:f2} leva.");
                        }
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        double boatRentSpringNew = boatRentSpring - boatRentSpring * 0.15;
                        if (fishersEven)
                        {
                            boatRentSpringNew = boatRentSpringNew - boatRentSpringNew * 0.05;
                        }
                        if (boatRentSpringNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentSpringNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSpringNew - budget:f2} leva.");
                        }
                    }
                    else
                    {
                        double boatRentSpringNew = boatRentSpring - boatRentSpring * 0.25;
                        if (fishersEven)
                        {
                            boatRentSpringNew = boatRentSpringNew - boatRentSpringNew * 0.05;
                        }
                        if (boatRentSpringNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentSpringNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSpringNew - budget:f2} leva.");
                        }
                    }
                    break;

                case "Autumn":
                case "Summer":


                    if (fishers <= 6)
                    {
                        double boatRentSummerNew = boatRentSummer - boatRentSummer * 0.1;
                        if (fishersEven && season == "Summer")
                        {
                            boatRentSummerNew = boatRentSummerNew - boatRentSummerNew * 0.05;
                        }
                        if (boatRentSummerNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentSummerNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSummerNew - budget:f2} leva.");
                        }
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        double boatRentSummerNew = boatRentSummer - boatRentSummer * 0.15;

                        if (fishersEven && season == "Summer")
                        {
                            boatRentSummerNew = boatRentSummerNew - boatRentSummerNew * 0.05;
                        }

                        if (boatRentSummerNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentSummerNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSummerNew - budget:f2} leva.");
                        }
                    }


                    else 
                    {
                       double boatRentSummerNew = boatRentSummer - boatRentSummer * 0.25;
                        if (fishersEven && season == "Summer")
                        {
                            boatRentSummerNew = boatRentSummerNew - boatRentSummerNew * 0.05;
                        }

                        if (boatRentSummerNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentSummerNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentSummerNew - budget:f2} leva.");
                        }
                    }
              
                    
                    break;

                case "Winter":
                    if (fishers <= 6)
                    {
                        double boatRentWinterNew = boatRentWinter - boatRentWinter * 0.1;
                        if (fishersEven)
                        {
                            boatRentWinterNew = boatRentWinterNew - boatRentWinterNew * 0.05;
                        }

                    if (boatRentWinterNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentWinterNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentWinterNew-budget:f2} leva.");
                        }
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        double boatRentWinterNew = boatRentWinter - boatRentWinter * 0.15;
                        if (fishersEven)
                        {
                            boatRentWinterNew = boatRentWinterNew - boatRentWinterNew * 0.05;
                        }

                        if (boatRentWinterNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentWinterNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentWinterNew - budget:f2} leva.");
                        }
                    }
                    else
                    {
                        double boatRentWinterNew = boatRentWinter - boatRentWinter * 0.25;
                        if (fishersEven)
                        {
                            boatRentWinterNew = boatRentWinterNew - boatRentWinterNew * 0.05;
                        }
                        if (boatRentWinterNew <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - boatRentWinterNew:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {boatRentWinterNew - budget:f2} leva.");
                        }
                    }
                    break;

            }

        }
    }
}
