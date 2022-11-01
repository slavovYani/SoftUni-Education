
namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double COFFE_MILLILITERS = 50;
        private const decimal COFFE_PRICE = 3.5m;
        private double caffeine;
        //private double coffeeMilliliters;
        //private decimal coffeePrice;
        public Coffee(string name, double caffeine) : base(name, COFFE_PRICE, COFFE_MILLILITERS)
        {
            Caffeine = caffeine;
            //coffeeMilliliters = COFFE_MILLILITERS;
            //coffeePrice = COFFE_PRICE;
        }


        //public decimal CoffeePrice
        //{
        //    get { return coffeePrice; }
        //    set { coffeePrice = COFFE_PRICE; }
        //}


        //public double CoffeeMilliliters
        //{
        //    get { return coffeeMilliliters; }
        //    set { coffeeMilliliters = COFFE_MILLILITERS; }
        //}

        public double Caffeine
        {
            get { return caffeine; }
            set { caffeine = value; }
        }

    }
}
