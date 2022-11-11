

namespace WildFarm.Models.Animal
{
    using WildFarm.Models.Food;
    using System.Collections.Generic;
    using System.Linq;
    using WildFarm.Exceptions;

    public abstract class Animal
    {
        protected string Name;
        protected double Weight;
        protected int FoodEaten;
        protected abstract double FoodWeightIncrement { get; }
        public abstract IReadOnlyCollection<string> AllowedFood { get; }

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        public abstract string MakeNoise();

        public void Eat(Food food)   //make it abstract
        {
            if (!this.AllowedFood.Contains(food.GetType().Name))
            {
                throw new NotEatableFoodException($"{this.GetType().Name} does not eat {food.GetType().Name}!");  // here with exceptionMessage or ??
            }

            this.Weight += food.Quantity* this.FoodWeightIncrement;
            this.FoodEaten += food.Quantity;

        }


    }
}
