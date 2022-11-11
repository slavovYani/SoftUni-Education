

namespace WildFarm.Factories.Interfaces
{
    using Models.Animal;
    public interface IBirdFactory
    {
        public Bird CreateBird(string type, string name, double weight, double wingsize);
    }
}
