
namespace Vehicles.Models
{
    using Interfaces;
    using System;
    using Vehicles.Exceptions;

    public class Car : IVehicle
    {
        private double fuelConsumption;
        private double fuelQuantity;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;   // * 0.9
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            private set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }

                else
                {
                    fuelQuantity = value;
                }


            }
        }

        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value + 0.9; }

        public double TankCapacity { get; private set; }

        public string Drive(double kilometers)
        {
            if (this.FuelQuantity - (this.FuelConsumption * kilometers) >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * kilometers;

                return $"Car travelled {kilometers} km";
            }

            return $"Car needs refueling";

        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException(FuelException.FUEL_NEGATIVE_NUMBER);
            }

            if (fuel > this.TankCapacity)
            {
                throw new ArgumentException(String.Format(FuelException.NOT_ENOUGH_FUELTANK_CAPACITY, fuel));
            }

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }

        
    }
}
