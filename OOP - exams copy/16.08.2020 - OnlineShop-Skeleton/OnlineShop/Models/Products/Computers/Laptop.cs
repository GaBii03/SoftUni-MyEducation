using System;
namespace OnlineShop.Models.Products.Computers
{
    public class Laptop : Computer
    {
        public Laptop
            (int id, string manifacturer, string model, decimal price)
            : base(id, manifacturer, model, price, 10)
        {
        }
    }
}
