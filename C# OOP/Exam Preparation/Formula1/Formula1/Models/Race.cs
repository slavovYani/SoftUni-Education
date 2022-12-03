
namespace Formula1.Models
{
    using Formula1.Models.Contracts;
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            pilots = new HashSet<IPilot>();
        }

        public string RaceName
        {
            get
            {
                return raceName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidRaceName, value));
                }

                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get
            {
                return numberOfLaps;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidLapNumbers, value));
                }

                this.numberOfLaps = value;
            }
        }


        public ICollection<IPilot> Pilots { get => pilots; }

        public bool TookPlace
        {
            get
            {
                return tookPlace;
            }
            set
            {

                this.tookPlace = value;
            }
        }

        public void AddPilot(IPilot pilot)
        {

            Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            string tookPlaceYesOrNo;

            if (tookPlace == false)
            {
                tookPlaceYesOrNo = "No";
            }
            else
            {
                tookPlaceYesOrNo = "Yes";
            }


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The {this.RaceName} race has:")
                .AppendLine($"Participants: {this.Pilots.Count}")
                .AppendLine($"Number of laps: {this.NumberOfLaps}")
                .AppendLine($"Took place: {tookPlaceYesOrNo}");

            return sb.ToString().Trim();

        }
    }
}
