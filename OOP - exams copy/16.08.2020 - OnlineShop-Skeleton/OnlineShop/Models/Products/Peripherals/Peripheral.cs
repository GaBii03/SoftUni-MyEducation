using System;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop
{
    public abstract class Peripheral : Product, IPeripheral
    {
        protected Peripheral
            (int id, string manifacturer, string model,
            decimal price, double overallPerformance, string connectionType)
            : base(id, manifacturer, model, price, overallPerformance)
        { 
           ConnectionType = connectionType;
        }

        public string ConnectionType { get; }

        public override string ToString()
        {
            return base.ToString() + $" Connection Type: {ConnectionType}";
        }
    }
}
