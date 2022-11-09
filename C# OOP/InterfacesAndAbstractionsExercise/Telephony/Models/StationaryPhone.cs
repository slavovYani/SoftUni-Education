
using System.Linq;
using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidNumberException();
            }

            return $"Dialing... {phoneNumber}";
        }

        private bool ValidatePhoneNumber(string phoneNumber) => phoneNumber.All(ch => char.IsDigit(ch));
    }
}
