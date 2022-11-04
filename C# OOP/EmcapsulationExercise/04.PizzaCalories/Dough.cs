

using System;
using System.Collections.Generic;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const double CALORIES_PER_GRAM = 2;
        private string flourType;
        private string backingTechnique;
        private double weight;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            { "white",1.5 },
            { "wholegrain",1.0 },
            { "crispy",0.9 },
            { "chewy",1.1 },
            { "homemade",1.0 }
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType 
        { 
            get 
            {
               return flourType;
            } 
            private set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    this.flourType = value;

                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
                
           
        }

        public string BakingTechnique { get => backingTechnique;
            private set
            {
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower()=="homemade")
                {
                    this.backingTechnique = value;

                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public double Weight { get => weight;
            private set 
            {
                if (value < 1 || value > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");

                this.weight = value;
            }
        }
        public double Calories => CalculateCalories(CALORIES_PER_GRAM, Weight, modifiers[FlourType.ToLower()], modifiers[BakingTechnique.ToLower()]);





        private double CalculateCalories(double caloriesPerGram, double weight, double typeOfFlour, double technique)
        {
            var result = (caloriesPerGram * weight) * typeOfFlour * technique;
            return result;
        }





    }
}
