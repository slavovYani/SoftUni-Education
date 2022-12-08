
namespace Heroes.Models.Map
{
    using Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using Heroes;

    public class Map : IMap
    {
        private readonly List<Barbarian> barbarians;
        private readonly List<Knight> knights;

        public Map()
        {
            barbarians = new List<Barbarian>();
            knights = new List<Knight>();
        }
        public string Fight(ICollection<IHero> players)
        {

            foreach (var player in players)
            {
                if (player.IsAlive)
                {

                    if (player.GetType() == typeof(Barbarian))
                    {
                        barbarians.Add((Barbarian)player);
                    }
                    else
                    {
                        knights.Add((Knight)player);
                    }
                }

            }
            int knightcasualties = 0;
            int barabiancasualties = 0;

            while (knights.Any() && barbarians.Any())
            {

                foreach (var knight in knights)
                {
                    if (knight.IsAlive)
                    {

                        foreach (var barbarian in barbarians.Where(b => b.IsAlive))
                        {
                            int weaponDurability = knight.Weapon.DoDamage();
                            barbarian.TakeDamage(weaponDurability);
                        }
                    }


                }


                foreach (var barbarian in barbarians)
                {
                    if (barbarian.IsAlive)
                    {
                        foreach (var knight in knights.Where(k => k.IsAlive))
                        {
                            int weaponDurability = barbarian.Weapon.DoDamage();
                            knight.TakeDamage(weaponDurability);
                        }

                    }


                }

                knightcasualties += knights.RemoveAll(k => !k.IsAlive);
                barabiancasualties += barbarians.RemoveAll(b => !b.IsAlive);

            }



            if (barbarians.Any())
            {
                
                return $"The barbarians took {barabiancasualties} casualties but won the battle.";

            }
            else
            {
                return $"The knights took {knightcasualties} casualties but won the battle.";
            }

        }
    }
}
