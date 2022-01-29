using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private List<IPeripheral> peripherals;
        private List<IComponent> components;

        protected Computer(int id, string manifacturer, string model, decimal price, double overallPerformance)
            : base(id, manifacturer, model, price, overallPerformance)
        {
            this.peripherals = new List<IPeripheral>();
            this.components = new List<IComponent>();
        }

        public IReadOnlyCollection<IComponent> Components => this.components;

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals;

        public override double OverallPerformance
        {
            get
            {
                if (components.Count == 0 )
                {
                    return base.OverallPerformance;
                }

                double sumOveralPerf = 0;
                foreach (var item in components)
                {
                    sumOveralPerf += item.OverallPerformance;
                }

                return base.OverallPerformance + (sumOveralPerf/components.Count);

            }
            protected set => base.OverallPerformance = value; }

        public override decimal Price
        {
           get
            {
                decimal totalSum = base.Price;
                foreach (var item in components)
                {
                    totalSum += item.Price;
                }
                foreach (var item in peripherals)
                {
                    totalSum += item.Price;
                }

                return totalSum;
            }
        }

        public void AddComponent(IComponent component)
        {
            if (Components.Any(x => x.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException
                    ($"Component {component.GetType().Name} already exists in {this.GetType().Name} with Id {this.Id}.");

            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (Peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException
                    ($"Component {peripheral.GetType().Name} already exists in {this.GetType().Name} with Id {this.Id}.");

            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (components.Count == 0 || !Components.Any(x => x.GetType().Name == componentType) )
            {
                throw new ArgumentException
                    ($"Component {componentType} does not exist in {this.GetType().Name} with Id {this.Id}.");
            }
            IComponent component = Components.First(X => X.GetType().Name == componentType);
            components.Remove(component);
            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Count == 0 || !Peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                throw new ArgumentException
                    ($"Peripheral {peripheralType} does not exist in {this.GetType().Name} with Id {this.Id}.");
            }
            IPeripheral peripheral = Peripherals.First(x => x.GetType().Name == peripheralType);
            peripherals.Remove(peripheral);
            return peripheral;

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($" Components ({components.Count}):");
            foreach (var item in components)
            {
                sb.AppendLine($"  {item}");
            }
            double sumAvrPerih = 0;
            foreach (var peripheral in peripherals)
            {
                sumAvrPerih += peripheral.OverallPerformance;
            }

            sumAvrPerih /= peripherals.Count;

            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({sumAvrPerih}):");
            foreach (var peripheral in peripherals)
            {
                sb.AppendLine($"  {peripheral}");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
