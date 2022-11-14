using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot = this.pilotRepository.FindByName(pilotName);
            IFormulaOneCar car = this.carRepository.FindByName(carModel);

            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException($"Pilot {pilotName} does not exist or has a car.");
            }

            if (car == null)
            {
                throw new NullReferenceException($"Car {carModel} does not exist.");
            }

            pilot.AddCar(car);
            this.carRepository.Remove(car);

            return $"Pilot {pilot.FullName} will drive a {pilot.Car.GetType().Name} {carModel} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IRace race = this.raceRepository.FindByName(raceName);
            IPilot pilot = this.pilotRepository.FindByName(pilotFullName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            if (pilot == null ||
                pilot.CanRace == false ||
                race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }

            race.AddPilot(pilot);

            return $"Pilot {pilot.FullName} is added to the {race.RaceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (this.carRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException($"Formula one car {model} is already created.");
            }

            IFormulaOneCar car;

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
                throw new InvalidOperationException($"Formula one car type {type} is not valid.");
            }

            carRepository.Add(car);

            return $"Car {car.GetType().Name}, model {car.Model} is created.";
        }

        public string CreatePilot(string fullName)
        {
            if (this.pilotRepository.FindByName(fullName) != null)
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }

            IPilot pilot = new Pilot(fullName);
            this.pilotRepository.Add(pilot);

            return $"Pilot {pilot.FullName} is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (this.raceRepository.FindByName(raceName) != null)
            {
                throw new InvalidOperationException($"Race {raceName} is already created.");
            }

            IRace race = new Race(raceName, numberOfLaps);
            this.raceRepository.Add(race);

            return $"Race {race.RaceName} is created.";
        }

        public string PilotReport()
        {
            StringBuilder result = new StringBuilder();

            foreach (IPilot pilot in pilotRepository.Models.OrderByDescending(pilot => pilot.NumberOfWins))
            {
                result.AppendLine($"Pilot {pilot.FullName} has {pilot.NumberOfWins} wins.");
            }

            return result.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            StringBuilder result = new StringBuilder();

            foreach (Race race in this.raceRepository.Models.Where(race => race.TookPlace == true))
            {
                result.AppendLine(race.RaceInfo());
            }

            return result.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException($"Race {race.RaceName} cannot start with less than three participants.");
            }

            if (race.TookPlace)
            {
                throw new InvalidOperationException($"Can not execute race {race.RaceName}.");
            }

            race.TookPlace = true;

            IEnumerable<IPilot> winnersIEnumerable = race.Pilots.OrderByDescending(pilot => pilot.Car.RaceScoreCalculator(race.NumberOfLaps)).Take(3);
            winnersIEnumerable.ElementAt(0).WinRace();
            StringBuilder winners = new StringBuilder();

            winners.AppendLine($"Pilot {winnersIEnumerable.ElementAt(0).FullName} wins the {race.RaceName} race.");
            winners.AppendLine($"Pilot {winnersIEnumerable.ElementAt(1).FullName} is second in the {race.RaceName} race.");
            winners.AppendLine($"Pilot {winnersIEnumerable.ElementAt(2).FullName} is third in the {race.RaceName} race.");

            return winners.ToString().TrimEnd();
        }
    }
}
