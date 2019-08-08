namespace ShoppingCart
{
    public class Discount
    {
        private int _discount = 10;
        
        public void UpdateDiscount(int percentage)
        {
            if(percentage <= 100)
            {
                _discount = percentage;
            }
            else
                throw new InvalidDiscountPercentage("Please Enter valid discount.");
        }

        public int GetDiscountPercentage()
        {
            return _discount;
        }
    }
}
