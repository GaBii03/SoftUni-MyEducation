using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IDecoration> decorations;
        private List<IFish> fishes;

        protected Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.decorations = new List<IDecoration>();
            this.fishes = new List<IFish>();
            
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.InvalidAquariumName);
                }

                this.name = value;
            }
        }

        public int Capacity { get; }

        public int Comfort
        {
            get
            {
                int totalComfort = 0;
                foreach (var decoration in this.Decorations)
                {
                    totalComfort += decoration.Comfort;
                }

                return totalComfort;
            }
        }

        public ICollection<IDecoration> Decorations => this.decorations;


        public ICollection<IFish> Fish => this.fishes;

        public void AddDecoration(IDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.Fish.Count == Capacity)
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.NotEnoughCapacity);
            }

            this.Fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var item in Fish)
            {
                item.Eat();
            }
        }

        public string GetInfo()
        {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine($"{this.Name} ({GetType().Name}):");
             sb.AppendLine($"Fish: {(this.Fish.Any() ? string.Join(", ", this.Fish) : "none")}");
             sb.AppendLine($"Decorations: {Decorations.Count}");
             sb.AppendLine($"Comfort: {this.Comfort}");

             return sb.ToString().TrimEnd();
           
        }

        public bool RemoveFish(IFish fish) => this.Fish.Remove(fish);
    }
}
