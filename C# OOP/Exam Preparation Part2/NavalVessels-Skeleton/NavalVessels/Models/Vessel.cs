

namespace NavalVessels.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contracts;
    using NavalVessels.Utilities.Messages;

    public abstract class Vessel : IVessel
    {
        private string name;
        private ICaptain captain;
        private double armorThickness;
        private double mainWeaponCaliber;
        private double speed;
        private List<string> targets;

        private Vessel()
        {
            targets = new List<string>();

        }

        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness) : this()
        {
            Name = name;
            MainWeaponCaliber = mainWeaponCaliber;
            Speed = speed;
            ArmorThickness = armorThickness;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(String.Format(ExceptionMessages.InvalidVesselName));

                name = value;
            }
        }
        public ICaptain Captain
        {
            get { return captain; }
            set
            {
                if (value is null)
                    throw new NullReferenceException(String.Format(ExceptionMessages.InvalidCaptainName));

                captain = value;
            }
        }

        public double ArmorThickness
        {
            get { return armorThickness; }
            set { armorThickness = value; }
        }
        public double MainWeaponCaliber
        {
            get { return mainWeaponCaliber; }
            protected set { mainWeaponCaliber = value; }             //here protected property??
        }

        public double Speed
        {
            get { return speed; }
            protected set { speed = value; }
        }

        public ICollection<string> Targets => targets; // here not sure;


        public void Attack(IVessel target)
        {
            if (target == null) throw new NullReferenceException(String.Format(ExceptionMessages.InvalidTarget));

            target.ArmorThickness -= this.MainWeaponCaliber;

            if (target.ArmorThickness < 0)
            {
                target.ArmorThickness = 0;
            }
            this.targets.Add(target.Name);

        }

        public abstract void RepairVessel();


        public override string ToString()
        {
            string targetsText;
            if (targets.Count == 0)
            {
                targetsText = "None";
            }
            else
            {
                targetsText = String.Join(", ", Targets);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {this.Name}").
                AppendLine($" *Type: {this.GetType().Name}").                         //here to check format
                AppendLine($" *Armor thickness: {this.ArmorThickness}").
                AppendLine($" *Main weapon caliber: {this.MainWeaponCaliber}").
                AppendLine($" *Speed: {this.Speed} knots").
                AppendLine($" *Targets: {targetsText}");                       //here to check format again

            return sb.ToString().TrimEnd();
        }
    }
}
