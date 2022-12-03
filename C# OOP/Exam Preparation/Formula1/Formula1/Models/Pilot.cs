

namespace Formula1.Models
{
    using Contracts;
    using Formula1.Utilities;
    using System;
    using System.Text;

    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;
        private bool canRace;
        private int numberOfWins;


        public Pilot(string fullName)
        {
            this.FullName = fullName;

        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPilot, value));
                }

                this.fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get
            {
                return car;
            }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException(String.Format(ExceptionMessages.InvalidCarForPilot));
                }

                this.car = value;
            }
        }

        public int NumberOfWins { get => numberOfWins; private set => numberOfWins = value; }

        public bool CanRace
        {
            get
            {
                return canRace;
            }
            private set
            {
                this.canRace = value;
            }
        }                   // here not sure!!

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.canRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Pilot {this.FullName} has {this.NumberOfWins} wins.");

            return sb.ToString().Trim();
        }
    }
}
