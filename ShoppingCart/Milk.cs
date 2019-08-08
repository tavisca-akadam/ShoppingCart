namespace ShoppingCart
{
    public class Milk : Product
    {
        public Milk(string name, int price)
        {
            this.Name = name;
            this.Price = price;
            ProductCategory = Category.dairy;
        }
        public override int Price { get; }

        public override string Name { get; }

        public override Category ProductCategory { get; }
    }
}
