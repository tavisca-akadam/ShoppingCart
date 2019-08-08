namespace ShoppingCart
{
    public abstract class Product
    {
        public abstract int Price { get; }
        public abstract string Name { get; }
        
        public abstract Category ProductCategory { get; }
    }
}
