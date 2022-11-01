using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private const double defaultFuelConsumption = 1.25;
        private double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }




        public virtual double FuelConsumption => defaultFuelConsumption;
        //{
        //    //get { return fuelConsumption; }
        //    //set { fuelConsumption = defaultFuelConsumption; }
        //}
        public virtual void Drive(double kilometers)
        {
            if (Fuel >= 0)
            {
                this.Fuel -= kilometers * FuelConsumption;

            }
        }



    }
}
