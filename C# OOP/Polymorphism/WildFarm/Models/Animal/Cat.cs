

namespace WildFarm.Models.Animal
{
    using System;
    using System.Collections.Generic;
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

       
        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Vegetable", "Meat" };
        protected override double FoodWeightIncrement => 0.30;
        public override string MakeNoise() => "Meow";
    }
}
