using WildFarm.Models.Food;

namespace WildFarm.Factories.Interfaces
{
    public interface IFoodFactory
    {
        Food CreateFoodFactory(string foodType, int foodQuantity);
    }
}
