using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart
    {
        private Dictionary<Product, int> _bucket = new Dictionary<Product, int>();

        public void AddToCart(Product product, int quantity)
        {
            if(_bucket.ContainsKey(product))
            {
                _bucket[product] += quantity;
            }
            else
            {
                _bucket.Add(product, quantity);
            }
        }

        public void RemoveFromCart(Product product, int quantity)
        {
            var updatedQuantity = _bucket[product] -= quantity;
            if(updatedQuantity <= 0)
            {
                _bucket.Remove(product);
            }
            else
            {
                _bucket[product] = updatedQuantity;
            }
        }

        public Dictionary<Product, int> GetCart()
        {
            if (_bucket.Count == 0)
                throw new CartEmptyException("Cart is Empty");
            return _bucket;
        }

        public double TotalCost()
        {
            var total = 0.0;
            if (_bucket.Count == 0)
                return total;
            foreach (var item in _bucket)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }
    }
}
