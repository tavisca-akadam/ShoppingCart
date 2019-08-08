using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using ShoppingCart;

namespace ShoppingCartProject
{
    public class IDiscountFixture
    {
        Cart myCart = new Cart();
        public void SetData()
        {
            Product milk = new Milk("Milk", 40);
            Product tShirt = new TShirt("T-Shirt", 400);
            Product shoes = new Shoes("shoes", 1500);

            
            myCart.AddToCart(milk, 2);
            myCart.AddToCart(tShirt, 3);
            myCart.AddToCart(shoes, 2);
        }

        [Fact]
        public void Check_category_wise_discount()
        {
            SetData();
            var categoryDiscount = new CategoryWiseDiscount();
            categoryDiscount.SetCategoryDiscount(Category.dairy, 10);
            categoryDiscount.SetCategoryDiscount(Category.footware, 30);
            categoryDiscount.SetCategoryDiscount(Category.clothing, 20);

            Dictionary<Category, int> list = categoryDiscount.GetList();


            var totalCost = categoryDiscount.GetDiscountTotal(myCart.GetCart());

            Assert.Equal(3132, totalCost);
        }

        [Fact]
        public void Check_fixed_discount_totalcost()
        {
            SetData();
            var fixedDiscount = new FixedDiscount();

            var actualResult = fixedDiscount.GetDiscountTotal(myCart.GetCart());

            Assert.Equal(3852, actualResult);
        }
    }
}
