
namespace Vehicles.Exceptions
{
    using System;
    public static class FuelException
    {
        public const string NOT_ENOUGH_FUELTANK_CAPACITY = "Cannot fit {0} fuel in the tank";
        public const string FUEL_NEGATIVE_NUMBER = "Fuel must be positive number";

        //public FuelException() : base(NOT_ENOUGH_FUELTANK_CAPACITY)
        //{

        //}
        //public FuelException(string message) : base(message)
        //{

        //}
    }
}
