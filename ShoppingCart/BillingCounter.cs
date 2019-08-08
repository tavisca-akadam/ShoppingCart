using System.Collections.Generic;

namespace ShoppingCart
{
    public class BillingCounter
    {
        private Dictionary<Product, int> _finalCart;
        private Cart _cart;
        public BillingCounter(Cart cart)
        {
            _cart = cart;
        }
        public double TotalCostWithDiscount()
        {
            _finalCart = _cart.GetCart();
            IDiscount discountType = DiscountFactory.GetDiscountType("Fixed");
            var total = 0.0;
            if (_finalCart.Count == 0)
                return total;

            total = discountType.GetDiscountTotal(_finalCart);
            return total;
        }
    }
}
