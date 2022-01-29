using System;
namespace OnlineShop.Models.Products.Peripherals
{
    public class Mouse : Peripheral
    {
        public Mouse
            (int id, string manifacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manifacturer, model, price, overallPerformance, connectionType)
        {
        }
    }
}
