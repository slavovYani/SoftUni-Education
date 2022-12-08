using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        private const double INITIAL_ARMOR_THICKNESS = 200;
        private bool submergeMode;
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, INITIAL_ARMOR_THICKNESS)
        {
            this.submergeMode = false;
        }

        public bool SubmergeMode
        {
            get => submergeMode;
            private set => submergeMode = value;
        }

        public override void RepairVessel()
        {
            if (this.ArmorThickness < 200)
            {
                this.ArmorThickness = INITIAL_ARMOR_THICKNESS;
            }
        }

        public void ToggleSubmergeMode()
        {
            if (!SubmergeMode)
            {
                SubmergeMode = true;
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
                

            }
            else
            {
                SubmergeMode = false;
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }

            

        }
        public override string ToString()
        {
            string text;

            text = (SubmergeMode) ? "ON" : "OFF";

            return base.ToString() + Environment.NewLine + $" *Submerge mode: {text}";
        }
    }
    
}
