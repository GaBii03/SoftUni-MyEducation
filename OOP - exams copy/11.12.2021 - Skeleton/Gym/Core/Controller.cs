using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipmentRepository;
        private List<IGym> gyms;

        public Controller()
        {
            equipmentRepository = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddAthlete
            (string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete = default;
            var gym = gyms.FirstOrDefault(x => x.Name == gymName);

            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }

            if ((gym.GetType().Name == "BoxingGym" && athleteType == "Weightlifter")
                || (gym.GetType().Name == "WeightliftingGym" && athleteType == "Boxer"))
            {
                return "The gym is not appropriate.";
            }

            gym.AddAthlete(athlete);
            return $"Successfully added {athleteType} to {gymName}.";

        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment = default;

            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }

            equipmentRepository.Add(equipment);
            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym = default;

            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }

            gyms.Add(gym);
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            var gym = gyms.FirstOrDefault(x => x.Name == gymName);
            double value = gym.EquipmentWeight;
            string output = $"The total weight of the equipment in the gym {gymName} is {value:f2} grams.";
            return output;
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            var equipment = equipmentRepository.FindByType(equipmentType);
            var gym = gyms.FirstOrDefault(x => x.Name == gymName);
            if (equipment == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }

            gym.AddEquipment(equipment);
            equipmentRepository.Remove(equipment);
            return $"Successfully added {equipmentType} to {gymName}.";

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            var gym = gyms.FirstOrDefault(x => x.Name == gymName);
            int counter = 0;
            foreach (var item in gym.Athletes)
            {
                item.Exercise();
                counter++;
            }

            return $"Exercise athletes: {counter}.";
        }
    }
}
