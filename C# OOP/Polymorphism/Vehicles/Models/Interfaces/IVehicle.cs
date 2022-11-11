
namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get;}
        public double FuelConsumption { get;}
        public double TankCapacity { get; }

        public string Drive(double kilometers);
        public void Refuel(double fuel);

        
    }
}
