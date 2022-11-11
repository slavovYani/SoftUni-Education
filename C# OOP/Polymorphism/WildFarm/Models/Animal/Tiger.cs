
namespace WildFarm.Models.Animal
{
    using System.Collections.Generic;
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override IReadOnlyCollection<string> AllowedFood => new HashSet<string>() { "Meat" };
        protected override double FoodWeightIncrement => 1.00;
        public override string MakeNoise() => "ROAR!!!";
    }
}
