﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const double CALORIES_PER_GRAM = 2;

        private string type;
        private double weight;
        

        private readonly Dictionary<string, double> types = new Dictionary<string, double>() 
        {
            {"meat",1.2 },
            {"veggies",0.8 },
            {"cheese",1.1 },
            {"sauce",0.9 },
        };

        public Topping(string type,double weight)
        {
            this.Type= type;
            this.Weight= weight;
        }

        public string Type
        {
            get { return type; }
            private set 
            {
                if(!types.ContainsKey(value.ToLower())) throw new ArgumentException($"Cannot place {value} on top of your pizza.");

                this.type = value;
            }
        }

        public double Weight
        {
            get { return weight; }
           private set 
            {
                if (value < 1 || value > 50) throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");

                this.weight = value; 
            }
        }


        public double CaloriesPerGram => CALORIES_PER_GRAM * types[Type.ToLower()]* Weight;
        
        




    }
}
