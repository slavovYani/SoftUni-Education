using System;

namespace Excercisess
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliasPrice = 3.8;
            double tulipsPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.50;

            double roseTotal = rosePrice * numberOfFlowers;
            double dahliasTotal = dahliasPrice * numberOfFlowers;
            double tulipsTotal = tulipsPrice * numberOfFlowers;
            double narcissusTotal = narcissusPrice * numberOfFlowers;
            double gladiolusTotal = gladiolusPrice * numberOfFlowers;

            double roseTotalWithDiscount = roseTotal - roseTotal * 0.1;
            double dahliasTotalWithDiscount = dahliasTotal - dahliasTotal * 0.15;
            double tulipsTotalWithDiscount = tulipsTotal - tulipsTotal * 0.15;
            double narcissusTotalWithDiscount = narcissusTotal * 1.15;
            double gladiolusTotalWithDiscount = gladiolusTotal*1.2;


            switch (typeFlower)
            {
                case "Roses":
                    if (numberOfFlowers > 80)
                    {
                        roseTotal = roseTotalWithDiscount;
                        if (roseTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - roseTotal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {roseTotal-budget:f2} leva more.");

                        }
                    }
                    else
                    {
                        if (roseTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - roseTotal:f2} leva left.");

                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {roseTotal - budget:f2} leva more.");

                        }
                    }break;

                case "Dahlias":
                    if (numberOfFlowers > 90)
                    {
                        dahliasTotal = dahliasTotalWithDiscount;
                        if (dahliasTotal < budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - dahliasTotal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {dahliasTotal - budget:f2} leva more.");

                        }
                    }
                    else
                    {
                        if (dahliasTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - dahliasTotal:f2} leva left.");

                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {dahliasTotal - budget:f2} leva more.");

                        }
                    }
                    break;
                case "Tulips":
                    if (numberOfFlowers > 80)
                    {
                        tulipsTotal = tulipsTotalWithDiscount;
                        if (tulipsTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - tulipsTotal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {tulipsTotal - budget:f2} leva more.");

                        }
                    }
                    else
                    {
                        if (tulipsTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - tulipsTotal:f2} leva left.");

                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {tulipsTotal - budget:f2} leva more.");

                        }
                    }
                    break;
                case "Narcissus":
                     if (numberOfFlowers < 120)
                    {
                        narcissusTotal = narcissusTotalWithDiscount;
                        if (narcissusTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - narcissusTotal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {narcissusTotal - budget:f2} leva more.");
                        }
                    }
                    else
                    {
                        if (narcissusTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - narcissusTotal:f2} leva left.");

                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {narcissusTotal - budget:f2} leva more.");

                        }
                    }
                    break;
                case "Gladiolus":
                    if (numberOfFlowers < 80)
                    {
                        gladiolusTotal = gladiolusTotalWithDiscount;
                        if (gladiolusTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - gladiolusTotal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {gladiolusTotal - budget:f2} leva more.");

                        }
                    }
                    else
                    {
                        if (gladiolusTotal <= budget)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {budget - gladiolusTotal:f2} leva left.");

                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {gladiolusTotal - budget:f2} leva more.");

                        }
                    }
                    break;


            }


        }

    }
}

