namespace ShoppingCart
{
    public class DiscountFactory
    {
        public static IDiscount GetDiscountType(string discountType)
        {
            switch(discountType)
            {
                case "Fixed":
                    return new FixedDiscount();

                case "CategoryWise":
                    return new CategoryWiseDiscount();

                default:
                    throw new InvalidDiscountType("Not Valid Type");
            }
        }
    }
}
