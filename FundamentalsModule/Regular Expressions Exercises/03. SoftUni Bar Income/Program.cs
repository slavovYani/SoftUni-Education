using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%(\w*?)<(?<product>\w+)>(\w*?)\|(?<count>\d+)\|(\w*?)(?<price>\d*\.\d*)\$|%(?<customer>[A-Z][a-z]+)%(\w*?)<(?<product>\w+)>(\w*?)\|(?<count>\d+)\|(\w*?)(?<price>\d+)\$";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern); 
            double totalAmountOfMoney = 0;

            
            while (input!="end of shift")
            {
                if (regex.Match(input).Success)
                {

                var name = regex.Match(input).Groups["customer"].Value;
                var product = regex.Match(input).Groups["product"].Value;
                var count = int.Parse(regex.Match(input).Groups["count"].Value);
                var priceProduct = double.Parse(regex.Match(input).Groups["price"].Value);
                var totalPriceProduct = priceProduct * count;

                Console.WriteLine($"{name}: {product} - {totalPriceProduct:f2}");

                totalAmountOfMoney+=totalPriceProduct;



                }
                input = Console.ReadLine();

            }


            Console.WriteLine($"Total income: {totalAmountOfMoney:f2}");
        }
    }
}
