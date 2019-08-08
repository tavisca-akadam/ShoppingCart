using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using ShoppingCart;

namespace ShoppingCartProject
{
    public class BillingSystemFixture
    {
        [Fact]
        public void Check_total_cost_without_discount()
        {
            Product milk = new Milk("Milk", 40);
            Product tShirt = new TShirt("T-Shirt", 400);
            Product shoes = new Shoes("shoes", 1500);

            Cart myCart = new Cart();
            myCart.AddToCart(milk, 2);
            myCart.AddToCart(tShirt, 3);
            myCart.AddToCart(shoes, 2);
            

            myCart.TotalCost().Should().Be(4280);
        }
        [Fact]
        public void Check_total_cost_with_discount()
        {
            Product milk = new Milk("Milk", 40);
            Product tShirt = new TShirt("T-Shirt", 400);
            Product shoes = new Shoes("shoes", 1500);

            Cart myCart = new Cart();
            myCart.AddToCart(milk, 2);
            myCart.AddToCart(tShirt, 3);
            myCart.AddToCart(shoes, 2);

            BillingCounter counter = new BillingCounter(myCart);

            counter.TotalCostWithDiscount().Should().Be(3852);
        }
    }
}
