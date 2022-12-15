
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int boothId;
        private int capacity;
        private double currentBill;
        private double turnover;
        private bool isReserved;
        private IRepository<ICocktail> cocktails;
        private IRepository<IDelicacy> delicacies;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            cocktails = new CocktailRepository();
            delicacies = new DelicacyRepository();
        }

        public int BoothId { get => boothId; private set => boothId = value; }

        public int Capacity
        {
            get => capacity; private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => delicacies;

        public IRepository<ICocktail> CocktailMenu => cocktails;       // with set and gets?

        public double CurrentBill { get => currentBill;  set => currentBill = value; }

        public double Turnover { get => turnover; private set => turnover = value; }

        public bool IsReserved { get => isReserved; private set => isReserved = value; }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }
        public void Charge()
        {
            Turnover += CurrentBill;
            CurrentBill = 0;
        }
        public void ChangeStatus()
        {
            IsReserved=!IsReserved;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Booth: {BoothId}")
                .AppendLine($"Capacity: {Capacity}")
                .AppendLine($"Turnover: {Turnover:F2} lv")
                .AppendLine($"-Cocktail menu:");

            foreach (var item in cocktails.Models)
            {
                sb.AppendLine($"--{item}".TrimEnd());
            }

            sb.AppendLine($"-Delicacy menu:");

            foreach (var item in delicacies.Models)
            {
                sb.AppendLine($"--{item}".TrimEnd());
            }

                
            return sb.ToString().TrimEnd();
        }


    }
}
