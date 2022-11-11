
using Raiding.Interfaces;
using Raiding.Models;

namespace Raiding.Factories.Interfaces
{
    public interface IBaseHeroFactory
    {
        BaseHero CreateHero(string type, string name);
    }
}
