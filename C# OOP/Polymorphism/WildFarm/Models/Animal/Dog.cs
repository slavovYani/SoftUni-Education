

namespace WildFarm.Models.Animal
{
    using System.Collections.Generic;
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Meat" };
        protected override double FoodWeightIncrement => 0.40;
        public override string MakeNoise() => "Woof";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

        }
    }
}
