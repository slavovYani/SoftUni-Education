
namespace WildFarm.Models.Food
{
    public abstract class Food
    {
        public int Quantity;

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
