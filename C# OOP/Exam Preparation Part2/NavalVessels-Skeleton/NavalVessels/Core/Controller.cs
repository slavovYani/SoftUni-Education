
namespace NavalVessels.Core
{
    using Contracts;
    using NavalVessels.Models;
    using NavalVessels.Models.Contracts;
    using NavalVessels.Repositories;
    using NavalVessels.Repositories.Contracts;
    using NavalVessels.Utilities.Messages;
    using System.Collections.Generic;
    using System.Linq;


    public class Controller : IController
    {
        private readonly IRepository<IVessel> vessels;
        private readonly HashSet<ICaptain> captains;
        public Controller()
        {
            captains = new HashSet<ICaptain>();
            vessels = new VesselRepository(); // check here
        }
        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {

            ICaptain captain = captains.FirstOrDefault(c => c.FullName == selectedCaptainName);
            IVessel vessel = vessels.FindByName(selectedVesselName);

            if (captain == null)
            {
                return string.Format(OutputMessages.CaptainNotFound, selectedCaptainName);
            }

            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, selectedVesselName);
            }

            if (vessel.Captain != null)
            {
                return string.Format(OutputMessages.VesselOccupied, selectedVesselName);    //here for check again
            }

            vessel.Captain = captain;
            captain.AddVessel(vessel);

            //  here not sure again!!

            return string.Format(OutputMessages.SuccessfullyAssignCaptain, selectedCaptainName, selectedVesselName);
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            IVessel attackingVessel = vessels.FindByName(attackingVesselName);
            IVessel defendingVessel = vessels.FindByName(defendingVesselName);

            if (attackingVessel is null)
            {
                return string.Format(OutputMessages.VesselNotFound, attackingVesselName);
            }

            if (defendingVessel is null)
            {
                return string.Format(OutputMessages.VesselNotFound, defendingVesselName);
            }

            if (attackingVessel.ArmorThickness == 0)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
            }
            if (defendingVessel.ArmorThickness == 0)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);

            }
            
            
                attackingVessel.Captain.IncreaseCombatExperience();
                defendingVessel.Captain.IncreaseCombatExperience();
                attackingVessel.Attack(defendingVessel);

                return string.Format(OutputMessages.SuccessfullyAttackVessel,
                    new object[] { defendingVesselName, attackingVesselName, defendingVessel.ArmorThickness });
            


        }

        public string CaptainReport(string captainFullName)
        {
            ICaptain captain = captains.First(c => c.FullName == captainFullName);

            //if (captain!=null)

            return captain.Report();

        }

        public string HireCaptain(string fullName)
        {
            ICaptain captain = new Captain(fullName);
           

            if (captains.Any(c => c.FullName == fullName))
            {
                return string.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }
            else
            {
                captains.Add(captain);
                return string.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);

            }

            
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            IVessel vessel;

            if (vessels.FindByName(name) != null)
            {
                return string.Format(OutputMessages.VesselIsAlreadyManufactured,
                    new object[] { vesselType, name });
            }

            if (vesselType == "Submarine")
            {
                vessel = new Submarine(name, mainWeaponCaliber, speed);
            }
            else if (vesselType == "Battleship")
            {
                vessel = new Battleship(name, mainWeaponCaliber, speed);

            }
            else
            {
                return string.Format(OutputMessages.InvalidVesselType);
            }


            //here this if can be added to the upper ?

            vessels.Add(vessel);

            return string.Format(OutputMessages.SuccessfullyCreateVessel,
                new object[] { vesselType, name, mainWeaponCaliber, speed });

        }

        public string ServiceVessel(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, vesselName);
            }

            vessel.RepairVessel();

            return string.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
        }

        public string ToggleSpecialMode(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel is null)
            {
                return string.Format(OutputMessages.VesselNotFound, vesselName);
            }

            if (vessel.GetType() == typeof(Battleship))       //here not sure
            {
                Battleship battleship = (Battleship)vessel;
                battleship.ToggleSonarMode();

                return string.Format(OutputMessages.ToggleBattleshipSonarMode, battleship.Name);
            }
            else /*if (vessel.GetType() == typeof(Submarine))*/
            {
                Submarine submarine = (Submarine)vessel;
                submarine.ToggleSubmergeMode();

                return string.Format(OutputMessages.ToggleSubmarineSubmergeMode, submarine.Name);
            }

        }

        public string VesselReport(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            //if(vessel == null) ?? 

            return vessel?.ToString().Trim();
        }
    }
}
