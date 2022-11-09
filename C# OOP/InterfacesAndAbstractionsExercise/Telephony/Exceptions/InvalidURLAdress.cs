
namespace Telephony.Exceptions
{
    using System;
    public class InvalidURLAdress : Exception
    {
        private const string InvalidURLMessage = "Invalid URL!";

        public InvalidURLAdress() : base(InvalidURLMessage)
        {

        }
        public InvalidURLAdress(string message) : base(message)
        {

        }
    }
}
