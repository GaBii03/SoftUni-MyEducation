using System;
namespace OnlineShop.Models.Products.Peripherals
{
    public class Headset : Peripheral
    {
        public Headset
            (int id, string manifacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manifacturer, model, price, overallPerformance, connectionType)
        {
        }
    }
}
