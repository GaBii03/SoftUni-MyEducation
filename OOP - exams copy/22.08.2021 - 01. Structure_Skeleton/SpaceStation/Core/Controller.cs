using System;
using System.Linq;
using System.Text;
using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IAstronaut> astronautRepo;
        private readonly IRepository<IPlanet> planetRepo;
        private readonly Mission mission;
        private int exploredPlanets;

        public Controller()
        {
            astronautRepo = new AstronautRepository();
            planetRepo = new PlanetRepository();
            mission = new Mission();
        }


        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = default;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            astronautRepo.Add(astronaut);
            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            this.planetRepo.Add(planet);
            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string ExplorePlanet(string planetName)
        {
            var astronauts = this.astronautRepo.Models
                .Where(x => x.Oxygen > 60).ToList();
            if (!astronauts.Any())
            {
                throw new InvalidOperationException
                    (ExceptionMessages.InvalidAstronautCount);
            }

            exploredPlanets++;
            var planet = this.planetRepo.FindByName(planetName);
            this.mission.Explore(planet, astronauts);
            int deadAstronauts = 0;

            foreach (var astronaut in astronauts)
            {
                if (!astronaut.CanBreath)
                {
                    deadAstronauts++;
                }
            }

            return string.Format(OutputMessages.PlanetExplored, planetName, deadAstronauts);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var item in astronautRepo.Models)
            {
                sb.AppendLine($"Name: {item.Name}");
                sb.AppendLine($"Oxygen: {item.Oxygen}");
                string itemsInfo = item.Bag.Items.Any() ?
                    string.Join(", ", item.Bag.Items) : "none";
                sb.AppendLine($"Bag items: {itemsInfo}");
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = astronautRepo.FindByName(astronautName);
            if (astronaut == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }

            astronautRepo.Remove(astronaut);
            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }
    }
}
