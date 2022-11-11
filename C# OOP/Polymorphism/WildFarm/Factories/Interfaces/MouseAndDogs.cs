
namespace WildFarm.Factories.Interfaces
{
    using WildFarm.Exceptions;
    using WildFarm.Models.Animal;
    public class MouseAndDogs : IMouseAndDogs
    {
        public Mammal CreateMouseOrDog(string type, string name, double weight, string livinRegion)
        {
            Mammal mammal;

            if (type == "Mouse")
            {
                mammal = new Mouse(name, weight, livinRegion);
            }
            else if (type == "Dog")
            {
                mammal = new Dog(name, weight, livinRegion);
            }
            else
            {
                throw new InvalidTypeException();
            }

            return mammal;
        }
    }
}
