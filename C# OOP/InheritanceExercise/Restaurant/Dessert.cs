﻿
namespace Restaurant
{
    public class Dessert : Food
    {
        private double calories;

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
    }
}
