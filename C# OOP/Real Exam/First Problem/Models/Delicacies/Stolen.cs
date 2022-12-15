
namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        private const double PRICE_FOR_BREAD = 3.50;

        public Stolen(string name) : base(name, PRICE_FOR_BREAD)
        {
        }
    }
}
