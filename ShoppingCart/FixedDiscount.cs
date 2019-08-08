using System.Collections.Generic;

namespace ShoppingCart
{
    public class FixedDiscount : IDiscount
    {
        private const int FixedDiscountPercentage = 10;
        public double GetDiscountTotal(Dictionary<Product, int> cart)
        {
            double cost = 0.0;
            foreach (var item in cart)
            {
                cost += (item.Key.Price * item.Value);
            }
            return cost - (cost * FixedDiscountPercentage / 100);
        }
    }
}
