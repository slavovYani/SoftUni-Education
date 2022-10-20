using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new Dictionary<string, Stock>();
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }

        public Dictionary<string, Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count => Portfolio.Count;

        public void BuyStock(Stock stock)


        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.MoneyToInvest -= stock.PricePerShare;
                Portfolio.Add(stock.CompanyName, stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!Portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";

            }
            if (sellPrice < Portfolio[companyName].PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            else
            {
                this.MoneyToInvest += sellPrice;
                Portfolio.Remove(companyName);
                return $"{companyName} was sold.";
            }
        }

        public Stock FindStock(string companyName)
        {
            if (Portfolio.ContainsKey(companyName))
            {
                return Portfolio[companyName];
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (!Portfolio.Any())
            {
                return null;
            }
            Stock biggestCompany = new Stock();

            foreach (var company in Portfolio.Values)
            {
                if (company.MarketCapitalization > biggestCompany.MarketCapitalization)
                {
                    biggestCompany = company;
                }
            }

            return biggestCompany;
        } // here not sure

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");

            foreach (var item in Portfolio.Values)
            {
                sb.AppendLine(item.ToString().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }

    }
}