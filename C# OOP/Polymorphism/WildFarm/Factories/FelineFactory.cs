

namespace WildFarm.Factories
{
    using Exceptions;
    using Interfaces;
    using WildFarm.Models.Animal;
    public class FelineFactory : IFelineFactory
    {

        public Feline CreateFeline(string type, string name, double weight, string livingRegion, string breed)
        {
            Feline feline;

            if (type == "Cat")
            {
                feline = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                feline = new Tiger(name, weight, livingRegion, breed);
            }
            else
            {
                throw new InvalidTypeException();
            }

            return feline;
        }
    }
}
