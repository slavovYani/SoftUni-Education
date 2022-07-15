using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputForVehicles = Console.ReadLine().Split().ToArray();
            var vehicle = new Vehicle();
            var catalogue = new List<Vehicle>(); 
            double sumOfHorsePowerCars = 0;
            double sumOfHorsePowerTrucks = 0;
            short carsCounter = 0;
            short truckCounter = 0;

            while (inputForVehicles[0] != "End")
            {
                string typeOfVehicle = inputForVehicles[0];
                string modelOfVehicle = inputForVehicles[1];
                string colorOfVehicle = inputForVehicles[2];
                short horsePower = short.Parse(inputForVehicles[3]);

                vehicle = new Vehicle(typeOfVehicle, modelOfVehicle, colorOfVehicle, horsePower);
                catalogue.Add(vehicle);
                

                if (typeOfVehicle == "car")
                {
                    sumOfHorsePowerCars += horsePower;
                    carsCounter++;
                }
                else
                {
                    sumOfHorsePowerTrucks += horsePower;
                    truckCounter++;
                }

                inputForVehicles = Console.ReadLine().Split().ToArray();

            }

            var typeOfVehiclesToPrint = Console.ReadLine();
            var finalCatalogue = new List<Vehicle>();

            while (typeOfVehiclesToPrint !="Close the Catalogue")
            {
                foreach (var vehicle1 in catalogue)
                {
                    if (typeOfVehiclesToPrint==vehicle1.Model)
                    {
                        finalCatalogue.Add(vehicle1);
                    }
                }
                typeOfVehiclesToPrint = Console.ReadLine();

            }
            foreach (var vehicle1 in finalCatalogue)
            {
                Console.WriteLine($"Type: {vehicle1.Type.First().ToString().ToUpper()+ vehicle1.Type.Substring(1)}");
                Console.WriteLine($"Model: {vehicle1.Model}");
                Console.WriteLine($"Color: {vehicle1.Color}");
                Console.WriteLine($"Horsepower: {vehicle1.HorsePower}");
            }
            Console.WriteLine($"Cars have average horsepower of: {sumOfHorsePowerCars / carsCounter:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {sumOfHorsePowerTrucks / truckCounter:f2}.");

        }
    }
    class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(string type,string model,string color,short horsePower)
        {
            Type = type;
            Model=model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        
    }
}
