using System;
namespace OnlineShop.Models.Products.Peripherals
{
    public class Keyboard : Peripheral
    {
        public Keyboard
            (int id, string manifacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manifacturer, model, price, overallPerformance, connectionType)
        {
        }
    }
}
