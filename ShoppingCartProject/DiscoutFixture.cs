using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using ShoppingCart;

namespace ShoppingCartProject
{
    public class DiscoutFixture
    {
        [Fact]
        public void Check_fixed_discount_type()
        {
            IDiscount discount = DiscountFactory.GetDiscountType("Fixed");

            Assert.IsType<FixedDiscount>(discount);
        }

        [Fact]
        public void Check_category_discount_type()
        {
            IDiscount discount = DiscountFactory.GetDiscountType("CategoryWise");

            Assert.IsType<CategoryWiseDiscount>(discount);
        }
        [Fact]
        public void Check_incorrect_discount_type()
        {
            

            Assert.Throws<InvalidDiscountType>(() => DiscountFactory.GetDiscountType("Vender"));
        }
    }
}
