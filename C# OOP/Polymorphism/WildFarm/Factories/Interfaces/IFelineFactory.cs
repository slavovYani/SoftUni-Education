
namespace WildFarm.Factories.Interfaces
{
    using Models.Animal;
    public interface IFelineFactory
    {
        Feline CreateFeline(string type,string name, double weight, string livingRegion, string breed);
    }
}
