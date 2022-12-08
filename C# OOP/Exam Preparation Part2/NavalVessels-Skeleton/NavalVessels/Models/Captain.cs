

namespace NavalVessels.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contracts;
    using NavalVessels.Utilities.Messages;

    public class Captain : ICaptain
    {
        private string fullName;
        private int combatExperience;
        private HashSet<IVessel> vessels;
        public Captain(string fullName)
        {
            FullName = fullName;
            vessels = new HashSet<IVessel>();
        }

        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(String.Format(ExceptionMessages.InvalidCaptainName));
                fullName = value;
            }
        }

        public int CombatExperience
        {
            get => combatExperience; private set => combatExperience = value;     // could be increased by 10 ??
        }

        public ICollection<IVessel> Vessels => vessels;

        public void AddVessel(IVessel vessel)
        {
            if (vessel is null) 
                throw new NullReferenceException(String.Format(ExceptionMessages.InvalidVesselForCaptain));

            vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            combatExperience += 10;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{FullName} has {CombatExperience} combat experience and commands {vessels.Count} vessels.");

            if (vessels.Any())
            {
                foreach (var vessel in vessels)
                {
                    sb.AppendLine(vessel.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
