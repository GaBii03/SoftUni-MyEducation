using System;
using System.Collections.Generic;
using Gym.Models.Equipment.Contracts;
using Gym.Repositories.Contracts;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private readonly List<IEquipment> equipment;

        public EquipmentRepository()
        {
            equipment = new List<IEquipment>();
        }

        public IReadOnlyCollection<IEquipment> Models => this.equipment;

        public void Add(IEquipment model)
        {
            equipment.Add(model);
        }

        public IEquipment FindByType(string type)
        {
            IEquipment equipment = null;
            foreach (var item in this.equipment)
            {
                if (item.GetType().Name == type)
                {
                    equipment = item;
                    break;
                }
            }

            return equipment;
        }

        public bool Remove(IEquipment model) => equipment.Remove(model);
    }
}
