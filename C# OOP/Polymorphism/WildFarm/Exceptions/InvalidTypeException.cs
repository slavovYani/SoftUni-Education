
namespace WildFarm.Exceptions
{
    using System;
    public class InvalidTypeException : Exception
    {
        private const string MESSAGE = "Invalid type!";

        public InvalidTypeException() : base(MESSAGE)
        {

        }
    }
}
