using System;
namespace OnlineShop.Models.Products.Computers
{
    public class DesktopComputer : Computer
    {
        public DesktopComputer
            (int id, string manifacturer, string model, decimal price)
            : base(id, manifacturer, model, price, 15)
        {
        }
    }
}
