using System;
namespace OnlineShop.Models.Products.Peripherals
{
    public class Monitor : Peripheral
    {
        public Monitor
            (int id, string manifacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manifacturer, model, price, overallPerformance, connectionType)
        {
        }
    }
}
