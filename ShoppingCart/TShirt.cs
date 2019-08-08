namespace ShoppingCart
{
    public class TShirt : Product
    {
        public TShirt(string name, int price)
        {
            this.Price = price;
            this.Name = name;
            ProductCategory = Category.clothing;
        }

        public override int Price { get; }

        public override string Name { get; }
        public override Category ProductCategory { get; }
    }
}
