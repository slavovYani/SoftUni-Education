namespace Heroes.Models
{
    using Contracts;
    using System;


    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        protected Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Hero name cannot be null or empty.");

                this.name = value;
            }
        }


        public int Health
        {
            get => this.health;
            private set
            {
                if (value < 0) throw new ArgumentException("Hero health cannot be below 0.");

                this.health = value;
            }
        }

        public int Armour
        {
            get => this.armour;
            private set
            {
                if (value < 0) throw new ArgumentException("Hero armour cannot be below 0.");

                this.armour = value;
            }
        }

        public IWeapon Weapon
        {
            get => this.weapon;
            protected set
            {
                if (value is null) throw new ArgumentException("Weapon cannot be null.");

                this.weapon = value;
            }
        }

        public bool IsAlive => this.Health > 0;


        public void AddWeapon(IWeapon weapon)
        {

            this.Weapon = weapon;       //here only one weapon ??

        }

        public void TakeDamage(int points)
        {
            int leftArmour = this.Armour - points;             //Armour = 10    /   points = 15   /  Health = 20;
            int leftPoints = 0;

            if (leftArmour < 0)
            {
                this.Armour = 0;
                leftPoints = Math.Abs(leftArmour);

            }
            else
            {
                this.Armour = leftArmour;
            }


            if (this.Health - leftPoints <= 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= leftPoints;
            }
        }
    }
}
