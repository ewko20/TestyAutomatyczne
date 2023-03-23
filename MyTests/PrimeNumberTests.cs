using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using Moq;

namespace MyTests
{
    internal class PrimeNumberTests
    {
        [Test]
        public void CheckCountingAscendingPrimeNumbers()
        {
            var mock=new Mock<INumbersManager>();
            var list = new List<int>() { 1, 3, 2, 4, 5, 6 };
            mock.Setup(m=>m.SortNumbers(list, true)).Returns(new List<int>(){ 1,2,3,4,5,6});
            var primeNumber = new PrimeNumber(mock.Object, list, true);
            var actual = primeNumber.CountNumbers();
            Assert.IsTrue(actual.QuantityPrimeNumbers==3 && actual.QuantityNotPrimeNumbers==3);
        }

        [Test]
        public void CheckCountingDescendingPrimeNumbers()
        {
            var mock = new Mock<INumbersManager>();//tworzenie mocka typu INumbersManager, czyli interfejsu, z którego potrzebujemy metod
            var list = new List<int>() { 3, 5, 1, 2, 6 };//tworzymy liste liczb całkowitych potrzebnych jako parametr metody SortNumbers,<tu typ>
            mock.Setup(m => m.SortNumbers(list, false)).Returns(new List<int>() { 6, 5, 3, 2, 1 });//ustawiamy działanie metody SortNumbers-tworzy to stałą, dzięki temu mamy pewność, że zadziała
            var primeNmbers=new PrimeNumber(mock.Object, list, false);
            var actual = primeNmbers.CountNumbers();
            Assert.IsTrue(actual.QuantityPrimeNumbers==3 && actual.QuantityNotPrimeNumbers==2);

        

        }
    }
}
