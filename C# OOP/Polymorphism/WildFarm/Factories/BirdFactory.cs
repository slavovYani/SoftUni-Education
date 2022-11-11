

namespace WildFarm.Factories
{
    using Exceptions;
    using Models.Animal;
    using WildFarm.Factories.Interfaces;

    public class BirdFactory : IBirdFactory
    {
        public Bird CreateBird(string type, string name, double weight, double wingsize)
        {
            Bird bird;

            if (type == "Owl")
            {
                bird = new Owl(name, weight, wingsize);
            }

            else if (type == "Hen")
            {
                bird = new Hen(name, weight, wingsize);
            }
            else
            {
                throw new InvalidTypeException();
            }
            return bird;
        }
    }
}
