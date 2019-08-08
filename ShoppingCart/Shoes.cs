namespace ShoppingCart
{
    public class Shoes : Product
    {
        public Shoes(string name, int price)
        {
            this.Price = price;
            this.Name = name;
            ProductCategory = Category.footware;
        }

        public override int Price { get; }

        public override string Name { get; }
        public override Category ProductCategory { get; }
    }
}
