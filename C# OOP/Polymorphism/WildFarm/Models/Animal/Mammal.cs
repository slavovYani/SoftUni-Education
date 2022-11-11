
namespace WildFarm.Models.Animal
{
    public abstract class Mammal : Animal
    {
        protected string LivingRegion;
        

        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;

        }

        
    }
}
