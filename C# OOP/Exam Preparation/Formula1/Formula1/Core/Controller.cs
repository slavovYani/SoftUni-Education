
using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;
        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot currentpilot = pilotRepository.FindByName(pilotName);

            if (currentpilot == null || currentpilot.Car != null)
            {
                throw new InvalidOperationException
                    (String.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));

            }

            //PropertyInfo carPropertyy = currentpilot.GetType().GetProperty("Car");

            var currentCar = carRepository.FindByName(carModel);

            if (currentCar == null)
            {
                throw new NullReferenceException
                    (String.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));
            }

            currentpilot.AddCar(currentCar);

            carRepository.Remove(currentCar);

            return String.Format(OutputMessages.SuccessfullyPilotToCar,
                new object[] { pilotName, currentCar.GetType().Name, carModel });

        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var currentRace = raceRepository.FindByName(raceName);

            if (currentRace == null)
            {
                throw new NullReferenceException
                    (String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }

            var currentPilot = pilotRepository.FindByName(pilotFullName);

            if (currentPilot == null || currentPilot.CanRace == false || currentRace.Pilots.Contains(currentPilot)) // here not sure
            {
                throw new InvalidOperationException
                    (String.Format(ExceptionMessages.PilotDoesNotExistErrorMessage, pilotFullName));
            }

            currentRace.AddPilot(currentPilot);

            return String.Format(OutputMessages.SuccessfullyAddPilotToRace, new object[] { pilotFullName, raceName });
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {

            //// here to check type and model the same?
            var currentCar = carRepository.FindByName(model);

            if (currentCar != null)
            {

                throw new InvalidOperationException(String.Format(ExceptionMessages.CarExistErrorMessage, model));

            }
            //if (type != "Ferrari" && type != "Williams")
            //{
            //    throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidTypeCar, type));
            //}


            //Type typeOfCar = Type.GetType($"Formula1.Models.{type}"); // here for checking the reflection;

            //IFormulaOneCar car = (IFormulaOneCar)Activator.CreateInstance(typeOfCar, new object[] { model, horsepower, engineDisplacement });

            //carRepository.Add(car);

            //return String.Format(OutputMessages.SuccessfullyCreateCar, new object[] { type, model }); // here for check

            if (carRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.CarExistErrorMessage, model));
            }

            IFormulaOneCar car = null;

            if (type == "Ferrari")
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == "Williams")
            {
                car = new Williams(model, horsepower, engineDisplacement);

            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidTypeCar, type));
            }

            carRepository.Add(car);
            return String.Format(OutputMessages.SuccessfullyCreateCar, type, model);
        }

        public string CreatePilot(string fullName)
        {
            IPilot pilot = new Pilot(fullName);

            if (pilotRepository.FindByName(fullName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }

            pilotRepository.Add(pilot);

            return String.Format(OutputMessages.SuccessfullyCreatePilot, fullName);


        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race = new Race(raceName, numberOfLaps);

            if (raceRepository.FindByName(raceName) != null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }

            raceRepository.Add(race);

            return String.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();

            foreach (var pilot in pilotRepository.Models.OrderByDescending(p => p.NumberOfWins))
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().Trim();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();

            foreach (var race in raceRepository.Models.Where(r => r.TookPlace == true))
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().Trim();
        }

        public string StartRace(string raceName)
        {
            var currentRace = raceRepository.FindByName(raceName);

            if (currentRace == null)
                throw new NullReferenceException(String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));

            if (currentRace.Pilots.Count < 3)
                throw new InvalidOperationException(String.Format(ExceptionMessages.InvalidRaceParticipants, raceName));

            if (currentRace.TookPlace)
                throw new InvalidOperationException(String.Format(ExceptionMessages.RaceTookPlaceErrorMessage, raceName));

            List<IPilot> orderedPilots = currentRace.Pilots.OrderByDescending(p => p.Car.RaceScoreCalculator(currentRace.NumberOfLaps)).ToList();

            currentRace.TookPlace = true;
            orderedPilots[0].WinRace();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format(OutputMessages.PilotFirstPlace,
                new object[] { orderedPilots[0].FullName, currentRace.RaceName })).
                AppendLine(String.Format(OutputMessages.PilotSecondPlace,
                new object[] { orderedPilots[1].FullName, currentRace.RaceName })).
                AppendLine(String.Format(OutputMessages.PilotThirdPlace,
                new object[] { orderedPilots[2].FullName, currentRace.RaceName }));

            return sb.ToString().Trim();
        }
    }
}
