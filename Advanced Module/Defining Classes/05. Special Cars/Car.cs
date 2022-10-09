using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public Car()
        {

        }
       
       
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;   
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        //private double sumOfTirePressure;

        //public double SumOfTirePressure
        //{
        //    get { return sumOfTirePressure; }
        //    set { sumOfTirePressure = value; }
        //}


        public double SumOfTirePressure(int tireIndex, List<Tire[]> listOfTires)
        {
            double sumOfTirePressure = 0;

            foreach (var tire in listOfTires[tireIndex])
            {
                sumOfTirePressure += tire.Pressure;
            }
            


            return sumOfTirePressure;
        }

        public void Drive(double sumOfTirePressure, Car car)
        {
            //foreach (var car in cars)
            //{

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && sumOfTirePressure > 9 && sumOfTirePressure < 10)
                {

                    car.FuelQuantity = car.FuelQuantity - (car.FuelConsumption / 100 * 20);



                    Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
    
                }
            //}



        }



    }

    //public void Drive(double distance) 
    //{
    //    double result = this.FuelQuantity - (this.FuelConsumption * distance);

    //    if (result>0)
    //    {
    //        FuelQuantity = result;
    //        return;
    //    }

    //    Console.WriteLine($"Not enough fuel to perform this trip!");

    //}
    //public string WhoAmI() 
    //{
    //    return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";

    //}

}



