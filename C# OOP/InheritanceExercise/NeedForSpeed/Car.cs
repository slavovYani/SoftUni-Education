using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DEFAULT_CAR_CONSUMPTION = 3;

        // тук сетваме field-a да бъде 3, но така и FamilyCar го наследява.

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => DEFAULT_CAR_CONSUMPTION;

        public override void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }

    }
}
