

namespace WildFarm.Models.Animal
{
    using System.Collections.Generic;
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Vegetable", "Fruit" };

        protected override double FoodWeightIncrement => 0.10;
        public override string MakeNoise() => "Squeak";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
