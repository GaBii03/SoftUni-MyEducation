using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using Component = OnlineShop.Models.Products.Components.Component;
using IComponent = OnlineShop.Models.Products.Components.IComponent;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IComponent> components;

        public Controller()
        {
            computers = new List<IComputer>();
            components = new List<IComponent>();
        }

        public string AddComponent
            (int computerId, int id, string componentType, string manufacturer,
            string model, decimal price, double overallPerformance, int generation)
        {
            if (!computers.Any(x => x.Id == computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            if (components.Any(x => x.Id == id))
            {
                throw new ArgumentException("Component with this id already exists.");
            }

            IComponent component = default;
            if (componentType == "Motherboard")
            {
                component = new Motherboard(id, manufacturer, model, price, overallPerformance,generation);
            }
            else if (componentType == "PowerSupply")
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "SolidStateDrive")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "VideoCard")
            {
                component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "RandomAccessMemory")
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "CentralProcessingUnit")
            {
                component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
            }
            else
            {
                throw new ArgumentException("Component type is invalid.");
            }


            components.Add(component);
            return $"Component {componentType} with id {id} added successfully in computer with id {computerId}.";

        }

        public string AddComputer
            (string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (computers.Any(x => x.Id == id))
            {
                throw new ArgumentException("Computer with this id already exists.");
            }

            IComputer computer = default;
            if (computerType == "Laptop")
            {
                computer = new Laptop(id, manufacturer, model, price);
            }
            else if (computerType == "DesktopComputer")
            {
                computer = new DesktopComputer(id, manufacturer, model, price);
            }
            else
            {
                throw new ArgumentException("Computer type is invalid.");
            }


            computers.Add(computer);
            return $"Computer with id {computer.Id} added successfully.";
        }

        public string AddPeripheral
            (int computerId, int id, string peripheralType, string manufacturer,
            string model, decimal price, double overallPerformance, string connectionType)
        {
            throw new NotImplementedException();
        }

        public string BuyBest(decimal budget)
        {
            throw new NotImplementedException();
        }

        public string BuyComputer(int id)
        {
            throw new NotImplementedException();
        }

        public string GetComputerData(int id)
        {
            throw new NotImplementedException();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            if (!computers.Any(x => x.Id == computerId))
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            IComputer currComputer = computers.First(x => x.Id == computerId);
            currComputer.RemoveComponent(componentType);
            IComponent currComponent = components.First(x => x.GetType().Name == componentType);
            components.Remove(currComponent);
            return $"Successfully removed {componentType} with id {currComponent.Id}.";
            
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            throw new NotImplementedException();
        }
    }
}
