using System;
using Xunit;
using ShoppingCart;

namespace ShoppingCartProject
{
    public class ProductFixture
    {
        [Fact]
        public void Create_product_test()
        {
            Product product = new Milk("Milk", 40);
            

            Assert.Equal(40, product.Price);
        }
    }
}
