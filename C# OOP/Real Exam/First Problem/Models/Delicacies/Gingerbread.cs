
namespace ChristmasPastryShop.Models.Delicacies
{
    public class Gingerbread : Delicacy
    {
        private const double PRICE_FOR_BREAD = 4.00;
        public Gingerbread(string name) : base(name, PRICE_FOR_BREAD)             //here about the constructor ?? 
        {
        }
    }
}
