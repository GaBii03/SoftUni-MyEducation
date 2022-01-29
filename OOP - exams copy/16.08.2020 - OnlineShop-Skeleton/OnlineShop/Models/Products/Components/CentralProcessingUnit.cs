using System;
namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        public CentralProcessingUnit
            (int id, string manifacturer, string model, decimal price, double overallPerformance, int generation)
            : base(id, manifacturer, model, price, overallPerformance, generation)
        {
            this.OverallPerformance = overallPerformance * 1.25;
        }
    }
}
