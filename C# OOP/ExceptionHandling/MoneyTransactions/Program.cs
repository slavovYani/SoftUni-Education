using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputBankAccounts = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, double> bankAccounts = new Dictionary<int, double>();

            ArgumentException commandNotExist = new ArgumentException("Invalid command!");
            KeyNotFoundException accountNotExist = new KeyNotFoundException("Invalid account!");
            ArithmeticException notEnoughMoney = new ArithmeticException("Insufficient balance!");

            foreach (var bankAccount in inputBankAccounts)
            {
                string[] currentBankAccountInfo = bankAccount.Split("-");
                int numberOfAccount = int.Parse(currentBankAccountInfo[0]);
                double moneyInAccount = double.Parse(currentBankAccountInfo[1]);

                bankAccounts.Add(numberOfAccount, moneyInAccount);

            }
            string commArgs;
            while ((commArgs = Console.ReadLine()) != "End")
            {
                string[] commands = commArgs.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                int number = int.Parse(commands[1]);
                double money = double.Parse(commands[2]);
                try
                {
                    if (command == "Deposit")
                    {
                        bankAccounts[number] += money;
                    }
                    else if (command == "Withdraw")
                    {
                        if (money > bankAccounts[number])
                        {
                            throw notEnoughMoney;
                        }

                        bankAccounts[number] -= money;
                    }
                    else
                    {
                        throw commandNotExist;
                    }

                    Console.WriteLine($"Account {number} has new balance: {bankAccounts[number]:f2}");
                }
                catch (ArgumentException)
                {

                    Console.WriteLine(commandNotExist.Message);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine(accountNotExist.Message);
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine(notEnoughMoney.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }


            }


        }
    }
}
