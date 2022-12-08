﻿
namespace Heroes.Models.Weapons
{
    public class Claymore : Weapon
    {
        private const int DAMAGE = 20;
        public Claymore(string name, int durability) : base(name, durability)
        {
        }

        public override int DoDamage()
        {
            if (this.Durability == 0)
            {
                return 0;
            }
            this.Durability -= 1;

            
            // here before or after if to decrease


            return DAMAGE;
        }
    }
}
