using System.Collections.Generic;

namespace ShoppingCart
{
    public interface IDiscount
    {
        double GetDiscountTotal(Dictionary<Product, int> cart);
    }
}
