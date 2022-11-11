
namespace WildFarm.Factories.Interfaces
{
    using WildFarm.Models.Animal;
    public interface IAnimalFactory
    {
        Animal CreateAnimal(string[] commdArgs);
    }
}
