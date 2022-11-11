
using System;

namespace Raiding.Exceptions
{
    public class InvalidHeroException : Exception
    {
        private const string INVALID_HERO = "Invalid hero!";

        public InvalidHeroException() : base(INVALID_HERO)
        {

        }
    }
}
