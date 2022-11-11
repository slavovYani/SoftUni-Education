
namespace Vehicles.Models
{
    using Interfaces;
    using System;
    using Vehicles.Exceptions;

    public class Truck : IVehicle
    {
        private double fuelConsumption;
        private double fuelQuantity;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity; private set
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

        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value + 1.6; }

        public double TankCapacity { get; private set; }

        public string Drive(double kilometers)
        {
            if (this.FuelQuantity - (this.FuelConsumption * kilometers) >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * kilometers;

                return $"Truck travelled {kilometers} km";
            }

            return $"Truck needs refueling";

        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException(FuelException.FUEL_NEGATIVE_NUMBER);
            }

            

            if (fuel> this.TankCapacity)
            {
                throw new ArgumentException(String.Format(FuelException.NOT_ENOUGH_FUELTANK_CAPACITY, fuel));
            }

            this.FuelQuantity += fuel * 0.95;
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
