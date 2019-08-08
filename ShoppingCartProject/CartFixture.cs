using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using ShoppingCart;

namespace ShoppingCartProject
{
    public class CartFixture
    {
        [Fact]
        public void Add_item_in_cart()
        {
            Product milk = new Milk("Milk", 40);
            Product tShirt = new TShirt("T-Shirt", 400);
            Product shoes = new Shoes("shoes", 1500);

            Cart myCart = new Cart();
            myCart.AddToCart(milk, 2);
            myCart.AddToCart(tShirt, 3);
            myCart.AddToCart(shoes, 2);

            myCart.GetCart().Count.Should().Be(3);
        }

        [Fact]
        public void check_item_in_cart()
        {
            Product milk = new Milk("Milk", 40);
            Product tShirt = new TShirt("T-Shirt", 400);

            Cart myCart = new Cart();
            myCart.AddToCart(milk, 2);
            myCart.AddToCart(tShirt, 3);

            myCart.GetCart()[milk].Should().Be(2);
        }
    }
}
