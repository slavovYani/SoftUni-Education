
namespace Telephony.Models
{
    using Interfaces;
    using System.Linq;
    using Exceptions;
    public class SmartPhone : ISmartPhone
    {
        public string BrowseURL(string url)
        {
            if (ValidateUrlAdress(url))
            {
                throw new InvalidURLAdress();
            }
            return $"Browsing: {url}!";

        }

        private bool ValidateUrlAdress(string url) => url.Any(ch => char.IsDigit(ch));


        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidNumberException();
            }
            return $"Calling... {phoneNumber}";

        }

        private bool ValidatePhoneNumber(string phoneNumber) => phoneNumber.All(ch => char.IsDigit(ch));

    }
}
