using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class PrimeNumberTests
    {
        NumbersManager numbersManager;

        [SetUp]
        public void Setup()
        {
            numbersManager = new NumbersManager();
            Assert.IsInstanceOf(typeof(NumbersManager), numbersManager);
        }

        [Test]
        public void CheckPrimeNumbersAscending()
        {
            var primeNumber = new PrimeNumber(numbersManager,new List<int>{ 2,5,6,3,1},true);
            var actual=primeNumber.CountNumbers();
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == 3 && actual.QuantityNotPrimeNumbers == 2);

        }

        [Test]
        public void CheckExceptionWithZeroAndNegativeAscending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 2, 5, 3, 6, -1, 0 },true);
            //Assert
            Assert.Throws<Exception>(() => primeNumber.CountNumbers());

        }

        [Test]
        public void CheckExceptionWithZeroAscending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 4, 3, 6, 5, 0, 2 }, true);
            //Assert
            Assert.Throws<Exception>(() => primeNumber.CountNumbers());
        }

        [Test]
        public void CheckExceptionWithNegativeAscending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 4, 7, 6, 2, 4, -8 }, true);
            //Assert
            Assert.Throws <Exception> (() => primeNumber.CountNumbers());
        }

        [Test]
        public void CheckPrimeNumbersDescending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 4, 6, 2, 7, 5, 4},false);
            var actual = primeNumber.CountNumbers();
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == 3 && actual.QuantityNotPrimeNumbers == 3);
        }

        [Test]
        public void CheckExceptionWithZeroDescending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 1, 4, 7, 2, 0 },false);
            //Assert
            Assert.Throws<Exception>(() => primeNumber.CountNumbers);
        }

        [Test]
        public void CheckExceptionWithZeroAndNegativeDescending()
        {
            var primeNumber = new PrimeNumber(numbersManager, new List<int> { 3, 5, 7, 3, 0, -8, 4 },false);
            //Assert
            Assert.Throws<Exception>(()=>primeNumber.CountNumbers());
        }
    }

    
}
