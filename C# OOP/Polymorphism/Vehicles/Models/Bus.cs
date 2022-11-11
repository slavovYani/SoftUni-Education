

namespace Vehicles.Models
{
    using Interfaces;
    using System;
    using Vehicles.Exceptions;

    public class Bus : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;

            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
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

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            private set
            {
                this.fuelConsumption = value;

            }
        }

        public double TankCapacity { get; private set; }



        public string Drive(double kilometers)
        {
            if (this.FuelQuantity - ((this.FuelConsumption + 1.4) * kilometers) >= 0)
            {
                this.FuelQuantity -= (this.FuelConsumption + 1.4) * kilometers;

                return $"Bus travelled {kilometers} km";
            }

            return $"Bus needs refueling";
        }

        public string DriveEmpty(double kilometers)
        {
            if (this.FuelQuantity - (this.FuelConsumption * kilometers) >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * kilometers;

                return $"Bus travelled {kilometers} km";
            }

            return $"Bus needs refueling";
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
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}
