

namespace WildFarm.Models.Animal
{
    using System.Collections.Generic;
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Meat" };
        protected override double FoodWeightIncrement => 0.25;
        public override string MakeNoise() => "Hoot Hoot";
    }
}
