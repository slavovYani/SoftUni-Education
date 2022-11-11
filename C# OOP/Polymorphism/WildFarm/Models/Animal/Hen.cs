

namespace WildFarm.Models.Animal
{
    using System.Collections.Generic;
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Vegetable", "Meat", "Fruit", "Seeds" };

        protected override double FoodWeightIncrement => 0.35;
        
        public override string MakeNoise() => "Cluck";

    }
}
