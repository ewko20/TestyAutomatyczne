using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class TextOperationTests
    {
        LengthOperation operation;//operation to obiekt typu złożonego LengthOperation

        [SetUp]
        public void SetUp()
        {
            operation = new LengthOperation();
            Assert.IsInstanceOf<LengthOperation>(operation);
        }

        [Test]
        public void CheckAnagram()
        {
            var textOperation = new TextOperation(operation, "ewa", "wea");
            var actual = textOperation.GetNameCompare();
            var expected = "Anagram";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDifferentLength()
        {
            var textOpearation = new TextOperation(operation, "ewa", "ewcia");
            Assert.Throws<Exception>(()=>textOpearation.GetNameCompare());
        }

        [Test]
        public void CheckBrak()
        {
            var textOperation = new TextOperation(operation, "adam", "dama");
            var actual = textOperation.GetNameCompare();
            var expected = "Brak";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPalindrom()
        {
            var textOperation = new TextOperation(operation, "sos", "sos");
            var actual = textOperation.GetNameCompare();
            var expected = "Palindrom";
            Assert.AreEqual(expected, actual);

        }


    }
}
