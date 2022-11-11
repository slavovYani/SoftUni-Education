
namespace Vehicles.Core
{
    using System;
    using System.Linq;

    using IO;
    using Vehicles.Models;
    using Vehicles.Models.Interfaces;

    public class Engine : IEngine
    {
        IReader reader;
        IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] carInput = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] truckInput = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] busInput = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Car car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            Truck truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
            Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));


            int numberOfLines = int.Parse(reader.ReadLine());

            IVehicle vehicle;

            for (int i = 0; i < numberOfLines; i++)
            {

                try
                {
                    string[] command = reader.ReadLine().Split();


                    if (command[1] == "Car")
                    {
                        vehicle = (Car)car;

                    }
                    else if (command[1] == "Truck")
                    {
                        vehicle = (Truck)truck;
                    }
                    else
                    {
                        vehicle = (Bus)bus;

                    }

                    if (command[0] == "Drive")
                    {
                        writer.WriteLine(vehicle.Drive(double.Parse(command[2])));

                    }

                    else if (command[0] == "DriveEmpty")
                    {
                       
                        writer.WriteLine(bus.DriveEmpty(double.Parse(command[2]))); // here not maked good abstraction and polymorphism

                    }

                    else
                    {
                        vehicle.Refuel(double.Parse(command[2]));

                    }



                }
                catch (ArgumentException ae)
                {

                    writer.WriteLine(ae.Message);
                }




            }



            writer.WriteLine(car.ToString());
            writer.WriteLine(truck.ToString());
            writer.WriteLine(bus.ToString());
        }
    }
}
