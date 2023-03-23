using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class ShopClassTests
    {
        [Test]
        public void DiscountForNine()
        {
            //Arrange
            var shopClass = new ShopClass(2, 9);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void NumberOfItemsIsZero()
        {
            //Arrange
            var shopClass = new ShopClass(0, 9);
            //ActAssert
            Assert.Throws<Exception>(() => shopClass.CreateDiscount());

        }
        [Test]
        public void DiscountForTen()
        {
            //Arrange
            var shopClass = new ShopClass(5, 10);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 0.5;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]

        public void DiscountForTwentyNine()
        {
            //Arrange
            var shopClass = new ShopClass(5, 29);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 0.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountFor30()
        {
            //Arrange
            var shopClass = new ShopClass(10, 30);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 6.5;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void DiscountForFourtyNine()
        {
            //Arrange
            var shopClass = new ShopClass(10, 49);
            //Act
            var actual= shopClass.CreateDiscount();
            var expected = 6.5;
            //Assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void DiscountForFifty()
        {
            //Arrange
            var shopClass = new ShopClass(10, 50);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 12;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountForNinetyNine()
        {
            //Arrange
            var shopClass = new ShopClass(10, 99);
            //Act
            var actual=shopClass.CreateDiscount();
            var expected = 12;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountForOneHundred()
        {
            //Arrange
            var shopClass = new ShopClass(10, 100);
            //Act
            var actual= shopClass.CreateDiscount();
            var expected = 17.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DiscountForOneHundredAndOne()
        {
            //Arrange
            var shopClass = new ShopClass(10, 101);
            //Act
            var actual = shopClass.CreateDiscount();
            var expected = 17.5;
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
