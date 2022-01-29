using System;
using System.Collections.Generic;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            this.racers = new List<IRacer>();
        }

        public IReadOnlyCollection<IRacer> Models => this.racers;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }

            racers.Add(model);
        }

        public IRacer FindBy(string property)
        {
            foreach (var racer in racers)
            {
                if (racer.Username == property)
                {
                    return racer;
                }
            }

            return null;
        }

        public bool Remove(IRacer model) => racers.Remove(model);
    }
}
