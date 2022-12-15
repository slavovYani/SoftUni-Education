
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ChristmasPastryShop.Models.Cocktails
{
    public class MulledWine : Cocktail
    {
        private const double PRICE_FOR_LARGE = 13.50;

        public MulledWine(string name, string size) : base(name, size, PRICE_FOR_LARGE)       // here constant only for LARGE?
        {

        }
    }
}
