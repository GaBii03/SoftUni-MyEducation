using System;
using System.Collections.Generic;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> cars;

        public CarRepository()
        {
            cars = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models => this.cars;

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }

            cars.Add(model);
        }

        public ICar FindBy(string property)
        {
            foreach (var car in cars)
            {
                if (car.VIN == property)
                {
                    return car;
                }
            }

            return null;
        }

        public bool Remove(ICar model) => cars.Remove(model);
    }
}
