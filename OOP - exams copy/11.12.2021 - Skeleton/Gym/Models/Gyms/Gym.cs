using System;
using System.Collections.Generic;
using System.Text;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private List<IEquipment> equipment;
        private List<IAthlete> athletes;

        protected Gym(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            equipment = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                this.name = value;
            }

        }

        public int Capacity { get; }

        public double EquipmentWeight
        {
            get
            {
                double sumWeight = 0;
                foreach (var eachEquipment in equipment)
                {
                    sumWeight += eachEquipment.Weight;
                }
                return sumWeight;
            }
        }

        public ICollection<IEquipment> Equipment => this.equipment;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count==Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }

            athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            List<string> athletesNames = new List<string>();
            foreach (var item in athletes)
            {
                athletesNames.Add(item.FullName);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {this.GetType().Name}:");
            sb.Append("Athletes: ");
            if (athletes.Count == 0)
            {
                sb.AppendLine("No athletes");
            }
            else
            {
                sb.AppendLine(string.Join(", ", athletesNames));
            }
            sb.AppendLine($"Equipment total count: {equipment.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams ");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveAthlete(IAthlete athlete) => athletes.Remove(athlete);
    }
}