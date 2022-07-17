using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._1.Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                VehicleType vehicleType;
                bool isVehicleTypeCorrect = Enum.TryParse(input[0], true, out vehicleType);

                if (isVehicleTypeCorrect)
                {
                    string vehicleModel = input[1];
                    string vehicleColor = input[2];
                    int horsePower = int.Parse(input[3]);

                    var currentVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, horsePower);

                    vehicles.Add(currentVehicle);
                }
            }
            while (true)
            {
                string models = Console.ReadLine();

                if (models == "Close the Catalogue")
                {
                    break;
                }


                Vehicle desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == models);

                Console.WriteLine(desiredVehicle);
            }

            var cars = vehicles.Where(vehicle => vehicle.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(vehicle => vehicle.Type == VehicleType.Truck).ToList();

            double carsAverageHP = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double trucksAverageHP = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:f2}.");
        }
    }
    enum VehicleType
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {Type}");

            stringBuilder.AppendLine($"Model: {Model}");

            stringBuilder.AppendLine($"Color: {Color}");

            stringBuilder.AppendLine($"Horsepower: {HorsePower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
