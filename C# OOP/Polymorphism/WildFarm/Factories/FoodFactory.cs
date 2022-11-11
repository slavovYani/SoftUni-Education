
namespace WildFarm.Factories
{
    using Interfaces;
    using WildFarm.Exceptions;
    using WildFarm.Models.Food;

    public class FoodFactory : IFoodFactory
    {
        public Food CreateFoodFactory(string foodType, int foodQuantity)
        {
            Food product;

            if (foodType=="Vegetable")
            {
                product = new Vegetable(foodQuantity);
            }
            else if (foodType=="Fruit")
            {
                product = new Fruit(foodQuantity);
            }
            else if (foodType== "Meat")
            {
                product = new Meat(foodQuantity);
            }
            else if (foodType== "Seeds")
            {
                product = new Seeds(foodQuantity);
            }
            else
            {
                throw new InvalidTypeException();
            }

            return product;
        }
    }
}
