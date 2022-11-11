

namespace Raiding.Factories
{
    using Interfaces;
    using Raiding.Exceptions;
    using Raiding.Models;

    public class BaseHeroFactory : IBaseHeroFactory
    {

        public BaseHero CreateHero(string type, string name)
        {
            BaseHero baseHero;


            if (type == "Druid")
            {
                baseHero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                baseHero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                baseHero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                baseHero = new Warrior(name);

            }
            else
            {
                throw new InvalidHeroException();
            }

            return baseHero;

        }
    }
}
