namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int desiredSum = int.Parse(Console.ReadLine());

        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            return null;
        }
    }
}