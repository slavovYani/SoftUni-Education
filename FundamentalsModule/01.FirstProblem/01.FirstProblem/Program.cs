using System;

namespace _01.FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double moneyEarned = 0;
            double totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfCity = Console.ReadLine();
                double incomes = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());
                moneyEarned = incomes - expenses;
                double expensesThirdDay = 0;
                if (i%3==0)
                {
                    expensesThirdDay = expenses * 0.5;
                    moneyEarned -= expensesThirdDay;
                }
                if (i % 5 == 0)
                {
                    if (i%3==0)
                    {
                        moneyEarned += expensesThirdDay;
                    }

                    moneyEarned -= incomes * 0.1;


                }

                totalProfit += moneyEarned;

                Console.WriteLine($"In {nameOfCity} Burger Bus earned {moneyEarned:F2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
        }
    }
}
