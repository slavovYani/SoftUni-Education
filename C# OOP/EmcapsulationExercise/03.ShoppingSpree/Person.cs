
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
                this.name = value;
            }
        }


        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");

                this.money = value;
            }
        }

        public List<Product> BagOfProducts
        {
            get
            {
                return bagOfProducts;
            }
            set
            {
                bagOfProducts = value;
            }
        }

        public override string ToString()
        {
            if (this.BagOfProducts.Any())
            {
                return $"{this.Name} - {string.Join(", ", this.BagOfProducts)}".TrimEnd();
            }

            return $"{this.Name} - Nothing bought".TrimEnd();
        }

    }
}
