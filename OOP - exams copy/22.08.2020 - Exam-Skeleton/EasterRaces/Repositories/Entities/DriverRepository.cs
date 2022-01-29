using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly List<IDriver> models;


        public DriverRepository()
        {
            models = new List<IDriver>();
        }

        public void Add(IDriver model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return models.ToArray();
        }

        public IDriver GetByName(string name)
        {
            return models.First(x => x.Name == name);
        }

        public bool Remove(IDriver model) => models.Remove(model);
    }
}
