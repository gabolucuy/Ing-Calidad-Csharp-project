using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    class DiscountTest
    {
        [Test]
        public void TestFivePercentDiscount()
        {
            Discount discount = new Discount();
            double discountPrice;
            discountPrice = discount.calculateDiscount(1500.00F);

            Assert.AreEqual(1425.00F, discountPrice);
        }

        [Test]
        public void TestTenPercentDiscount()
        {
            Discount discount = new Discount();
            double discountPrice;
            discountPrice = discount.calculateDiscount(4000.00F);
            Assert.AreEqual(3600.00F, discountPrice);
        }

        [Test]
        public void TestFiftyPercentDiscount()
        {
            Discount discount = new Discount();
            double discountPrice;
            discountPrice = discount.calculateDiscount(10000.00F);
            Assert.AreEqual(5000.00F, discountPrice);
        }

        [Test]
        public void TestNoDiscount()
        {
            Discount discount = new Discount();
            double discountPrice;
            discountPrice = discount.calculateDiscount(20000.00F);
            Assert.AreEqual(20000.00F, discountPrice);
        }

        [Test]
        public void TestSalesAmountZeroError()
        {
            Discount discount = new Discount();            
            var ex = Assert.Throws<ArgumentException>(() => discount.calculateDiscount(0.00F));
            Assert.That(ex.Message == " Sales Amount should not be 'Zero/Negative'");
        }

        [Test]
        public void TestSalesAmountNegativeError()
        {
            Discount discount = new Discount();
            var ex = Assert.Throws<ArgumentException>(() => discount.calculateDiscount(-200.00F));
            Assert.That(ex.Message == " Sales Amount should not be 'Zero/Negative'");
        }
    }
}
