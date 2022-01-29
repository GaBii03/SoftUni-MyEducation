using System;
using System.Linq;
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private DriverRepository driverRepository;
        private CarRepository carRepository;
        private RaceRepository raceRepository;

        public ChampionshipController()
        {
            driverRepository = new DriverRepository();
            carRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = default;
            ICar car = default;

            if (carRepository.GetByName(carModel) == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }
            else
            {
                car = carRepository.GetByName(carModel);
            }

            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            else
            {
                driver = driverRepository.GetByName(driverName);
            }

            driver.AddCar(car);
            carRepository.Remove(car);
            return string.Format(Utilities.Messages.OutputMessages.CarAdded, driverName, carModel);
            
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = default;
            IDriver driver = default;

            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            else
            {
                race = raceRepository.GetByName(raceName);
            }

            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            else
            {
                driver = driverRepository.GetByName(driverName);
            }

            race.AddDriver(driver);
            driverRepository.Remove(driver);//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            return string.Format(Utilities.Messages.OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = default;

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            if (carRepository.GetByName(car.Model) != null)
            {
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.CarExists, model);
            }

            carRepository.Add(car);
            return string.Format($"{car.GetType().Name} {model} is created.");
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = default;
            if (driverRepository.GetByName(driverName) != null)
            {
                throw new ArgumentException(Utilities.Messages.ExceptionMessages.DriversExists, driverName);
            }

            driver = new Driver(driverName);
            this.driverRepository.Add(driver);
            return string.Format(Utilities.Messages.OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            if (raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            IRace race = new Race(name, laps);
            raceRepository.Add(race);
            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = default;

            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            else
            {
                race = raceRepository.GetByName(raceName);
            }

            if (race.Drivers.Count<3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var drivers = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();

            var first = drivers[0];
            var second = drivers[1];
            var third = drivers[2];

            raceRepository.Remove(race);

            return $"Driver {first.Name} wins {raceName} race." + Environment.NewLine +
                   $"Driver {second.Name} is second in {raceName} race." + Environment.NewLine +
                   $"Driver {third.Name} is third in {raceName} race.";
        }
    }
}
