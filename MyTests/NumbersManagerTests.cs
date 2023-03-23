using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class NumbersManagerTests
    {
        NumbersManager numbersManager;

        [SetUp]
        public void SetUp()
        {
            numbersManager = new NumbersManager();
            Assert.IsInstanceOf<NumbersManager>(numbersManager);
        }

        [Test]
        public void CheckSortAscendingPositiveNumbers()
        {
            var list = new List<int>() { 2, 6, 4, 6, 3, 78 };
            //Act
            var actual = numbersManager.SortNumbers(list, true);
            var expected = new List<int>() { 2, 3, 4, 6, 6, 78 };
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSortDescendingNumbersWithNegative()
        {
            var list = new List<int>() { 3, 6, 3, 7, -8 };
            //AssertAct
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(list, false));
        }

        [Test]
        public void CheckSortDescendingPositiveNumbers()
        {
            var list = new List<int>() { 4, 5, 7, 3, 8, 9, 1 };
            //Act
            var actual = numbersManager.SortNumbers(list, false);
            var expected = new List<int>() { 9, 8, 7, 5, 4, 3, 1 };
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSortAscendingNumbersWithNegative()
        {
            var list = new List<int>() { 4, 5, 7, -1 };
            //ActAssert
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(list, true));
        }

        [Test]
        public void CheckSortDescendingNumbersWithNegativeAndZero()
        {
            var list = new List<int>() { 1, 4, 2, 0, 5, -7 };
            //ActAssert
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(list, false));
        }

        [Test]
        public void CheckSortAscendingNumbersWithNegativeAndZero()
        {
            var list = new List<int>() { 1, 4, 2, 0, 5, -7 };
            //ActAssert
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(list, true));
        }


    }
}
