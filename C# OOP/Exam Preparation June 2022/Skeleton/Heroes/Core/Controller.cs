

namespace Heroes.Core
{
    using Contracts;
    using Heroes.Models;
    using Heroes.Models.Contracts;
    using Heroes.Models.Heroes;
    using Heroes.Models.Map;
    using Heroes.Models.Weapons;
    using Heroes.Repositories;
    using System;
    using System.Linq;
    using System.Text;
   

    public class Controller : IController
    {
        private HeroRepository heroes;
        private WeaponRepository weapons;
        public Controller()
        {
            heroes = new HeroRepository();
            weapons = new WeaponRepository();
        }
        public string CreateHero(string type, string name, int health, int armour)
        {
            IHero hero;

            if (type == "Barbarian")
            {
                hero = new Barbarian(name, health, armour);
            }
            else if (type == "Knight")
            {
                hero = new Knight(name, health, armour);
            }
            else
            {
                throw new InvalidOperationException("Invalid hero type");
            }

            if (heroes.Models.Any(h => h.Name == name))
            {
                throw new InvalidOperationException($"The hero {name} already exists.");
            }

            heroes.Add(hero);

            if (hero is Knight)           //here with typeof(hero) == Knight.GetType()  also possible
            {
                return $"Successfully added Sir {name} to the collection.";
            }
            else
            {
                return $"Successfully added Barbarian {name} to the collection.";

            }


        }
        public string CreateWeapon(string type, string name, int durability)
        {
            IWeapon weapon;

            if (type == "Claymore")
            {
                weapon = new Claymore(name, durability);
            }
            else if (type == "Mace")
            {
                weapon = new Mace(name, durability);
            }
            else
            {
                throw new InvalidOperationException("Invalid weapon type");
            }

            if (weapons.Models.Any(h => h.Name == name))
            {
                throw new InvalidOperationException($"The weapon {name} already exists.");
            }

            weapons.Add(weapon);
            return $"A {weapon.GetType().Name.ToLower()} {name} is added to the collection.";

        }
        public string AddWeaponToHero(string weaponName, string heroName)
        {
            if (!heroes.Models.Any(h => h.Name == heroName))
            {
                throw new InvalidOperationException($"Hero {heroName} does not exist.");
            }

            if (weapons.FindByName(weaponName) is null)
            {
                throw new InvalidOperationException($"Weapon {weaponName} does not exist.");
            }

            var currentHero = heroes.Models.First(h => h.Name == heroName);
            var currentWeapon = weapons.FindByName(weaponName);


            if (currentHero.Weapon != null)
            {
                throw new InvalidOperationException($"Hero {heroName} is well-armed.");
            }

            currentHero.AddWeapon(currentWeapon);
            weapons.Remove(currentWeapon);

            return $"Hero {heroName} can participate in battle using a {currentWeapon.GetType().Name.ToLower()}.";

        }
        public string StartBattle()
        {
            Map map = new Map();

            var heroesReady = this.heroes.Models.Where(h => h.IsAlive && h.Weapon != null).ToList();

            return map.Fight(heroesReady);
        }

        public string HeroReport()
        {
           
            var sortedHero = heroes.Models.OrderBy(h => h.GetType().Name).
                ThenByDescending(h => h.Health).
                ThenBy(h => h.Name).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var hero in sortedHero)
            {
                string weapon;

                if (hero.Weapon == null)
                {
                    weapon = "Unarmed";
                }
                else
                {
                    weapon = hero.Weapon.Name;
                }

                sb.AppendLine($"{hero.GetType().Name}: {hero.Name}")
                    .AppendLine($"--Health: {hero.Health}")
                    .AppendLine($"--Armour: {hero.Armour}")
                    .AppendLine($"--Weapon: {weapon}");
                      // here the empty line ??

            }

            return sb.ToString().TrimEnd();

        }

    }
}
