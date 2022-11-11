
namespace WildFarm.Factories.Interfaces
{
    using WildFarm.Models.Animal;
    public interface IMouseAndDogs
    {
        Mammal CreateMouseOrDog(string type, string name, double weight, string livinRegion);
    }
}
