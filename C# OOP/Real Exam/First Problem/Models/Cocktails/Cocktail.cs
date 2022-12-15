
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;

namespace ChristmasPastryShop.Models.Cocktails
{
    public class Cocktail : ICocktail
    {
        
        private string name;
        private double price;
        private string size;
        

        public Cocktail(string name,string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
            
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public string Size
        {       //here with size enum 
            get; private set;
        }

        public double Price
        {
            get { return price; }
            private set
            {
                if (Size == "Large")
                {
                    price = value;

                }
                else if (Size == "Middle")
                {
                    price = value * 0.6667;       /*(value / 3) * 2;   */        // HERE NOT SURE!
                }
                else if (Size == "Small")
                {
                    price = value * 0.3333;                                // HERE NOT SURE!

                }

            }
        }

        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price:f2} lv";
        }
    }
}
