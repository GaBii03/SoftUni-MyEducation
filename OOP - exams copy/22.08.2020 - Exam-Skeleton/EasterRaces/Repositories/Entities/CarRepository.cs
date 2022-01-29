using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> models;

        public CarRepository()
        {
            models = new List<ICar>();
        }

        public void Add(ICar model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return models.ToArray();
        }

        public ICar GetByName(string name)
        {
            return models.First(x => x.Model == name);
        }

        public bool Remove(ICar model) => models.Remove(model);
        
    }
}
