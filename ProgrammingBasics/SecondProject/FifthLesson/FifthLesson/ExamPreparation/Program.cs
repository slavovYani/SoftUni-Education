using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double inAccountMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpending = 0;

            while (inAccountMoney<neededMoney)
            {
                string spendOrSave = Console.ReadLine();
                double spendOrSaveSum = double.Parse(Console.ReadLine());
                days++;
                if (spendOrSave == "spend")
                {
                    daysSpending++;
                  
                    inAccountMoney -= spendOrSaveSum;

                    if (inAccountMoney <= 0)
                    {
                        inAccountMoney = 0;
                    }
                }
                else if (spendOrSave == "save")
                {
                    daysSpending = 0;
                    inAccountMoney += spendOrSaveSum;
                }

                if (daysSpending == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{daysSpending}");
                    return;

                }

            }
            Console.WriteLine($"You saved the money for {days} days.");


            
        }
    }
}
