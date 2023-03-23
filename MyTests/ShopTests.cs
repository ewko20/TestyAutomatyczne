using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class ShopTests
    {
        Shop shop;

        [SetUp]
        public void Initialize()
        {
            shop = new Shop();
            Assert.IsInstanceOf(typeof (Shop), shop);
        }

        [Test]
        public void DiscountForNine()
        {
            //Act
            var actual = shop.CreateDiscount(2, 9);
            var expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DiscountWithoutProducts()
        {
            //Assert
            Assert.Throws<Exception>(() => shop.CreateDiscount(0, 10));
        }

        [Test]
        public void DiscountFor10()
        {
            //Act
            var actual = shop.CreateDiscount(2, 10);
            var expected = 0.2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor29()
        {
            //Act
            var actual = shop.CreateDiscount(2, 29);
            var expected = 0.2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor30()
        {
            //Act
            var actual = shop.CreateDiscount(5, 30);
            var expected = 5.75;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor49()
        {
            //Act
            var actual = shop.CreateDiscount(5, 49);
            var expected = 5.75;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor50()
        {
            //Act
            var actual = shop.CreateDiscount(10, 50);
            var expected = 12;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor99()
        {
            //Act
            var actual = shop.CreateDiscount(10, 99);
            var expected = 12;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor100()
        {
            //Act
            var actual = shop.CreateDiscount(10, 100);
            var expected = 17.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor101()
        {
            //Act
            var actual = shop.CreateDiscount(10, 101);
            var expected = 17.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountWithNegativeNumberOfProducts()
        {
            //Assert
            Assert.Throws<Exception>(() => shop.CreateDiscount(-10, 10));
        }

    }
}
