using System.Collections.Generic;
using System.Diagnostics;

namespace ShoppingCart
{
    public class CategoryWiseDiscount : IDiscount
    {
        private const int DefaultDiscount = 0;
        private Dictionary<Category, int> _discountList = new Dictionary<Category, int>();
        public CategoryWiseDiscount()
        {
        }
        public void SetCategoryDiscount(Category category, int discount)
        {

            if (_discountList.ContainsKey(category))
                _discountList[category] = discount;
            else
                _discountList.Add(category, discount);
        }
        private int GetCategoryDiscount(Category category)
        {
            if (_discountList.ContainsKey(category))
            {
                _discountList.TryGetValue(category, out int value);
                return value;
            }   
            else
                return DefaultDiscount;
        }
        public double GetDiscountTotal(Dictionary<Product, int> cart)
        {
            double cost = 0.0;
            foreach(var item in cart)
            {
                int totalPrice = item.Key.Price * item.Value;
                cost += totalPrice - (totalPrice * GetCategoryDiscount(item.Key.ProductCategory) / 100);
               
            }
            return cost;
        }
        public Dictionary<Category, int> GetList()
        {
            return _discountList;
        }
    }
}
