
namespace ChristmasPastryShop.Models.Cocktails
{

    public class Hibernation : Cocktail
    {
        private const double PRICE_FOR_LARGE = 10.50;

        public Hibernation(string name, string size) : base(name, size, PRICE_FOR_LARGE)    // HERE NOT SURE!
        { 
        }
    }
}
