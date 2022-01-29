using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = default;
            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.InvalidAquariumType);
            }

            aquariums.Add(aquarium);
            return string.Format(Utilities.Messages.OutputMessages.SuccessfullyAdded, aquariumType);

        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = default;
            if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.InvalidDecorationType);
            }

            decorations.Add(decoration);
            return string.Format(Utilities.Messages.OutputMessages.SuccessfullyAdded, decorationType);

        }

        public string AddFish
            (string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = default;

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName,fishSpecies,price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(Utilities.Messages.ExceptionMessages.InvalidFishType);
            }

            IAquarium currAquarium = aquariums.First(x => x.Name == aquariumName);
            if ((fishType == "FreshwaterFish" && currAquarium.GetType().Name == "SaltwaterAquarium") || (fishType == "SaltwaterFish" && currAquarium.GetType().Name == "FreshwaterAquarium"))
            {
                return string.Format(Utilities.Messages.OutputMessages.UnsuitableWater);
            }

            currAquarium.AddFish(fish);
            return string.Format(Utilities.Messages.OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
            
        }

        public string CalculateValue(string aquariumName)
        {
            decimal totalPrice = 0;
            IAquarium currAquarium = aquariums.First(x => x.Name == aquariumName);

            foreach (var item in currAquarium.Fish)
            {
                totalPrice += item.Price;
            }

            foreach (var item in currAquarium.Decorations)
            {
                totalPrice += item.Price;
            }

            return string.Format(Utilities.Messages.OutputMessages.AquariumValue, aquariumName, totalPrice);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium currAquarium = aquariums.First(x => x.Name == aquariumName);
            foreach (var fish in currAquarium.Fish)
            {
                fish.Eat();
            }

            return string.Format(Utilities.Messages.OutputMessages.FishFed, currAquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium currAquarium = aquariums.First(x => x.Name == aquariumName);
            IDecoration currDecoration = decorations.FindByType(decorationType);
            if (currAquarium == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            currAquarium.AddDecoration(currDecoration);
            decorations.Remove(currDecoration);

            return string.Format(Utilities.Messages.OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in aquariums)
            {
                sb.Append(item.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
