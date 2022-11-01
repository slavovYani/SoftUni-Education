using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DEFAULT_SPORTSCAR_CONSUMPTION = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => DEFAULT_SPORTSCAR_CONSUMPTION;
    }
}
