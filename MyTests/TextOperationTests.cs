using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using Moq;

namespace MyTests
{
    internal class TextOperationTests
    {

        [Test]
        public void Setup()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("sedes", "sedes")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "sedes", "sedes");
            Assert.IsInstanceOf(typeof(TextOperation), textOperation);


        }
        [Test]
        public void CheckPalindrom()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("sedes", "sedes")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "sedes", "sedes");
            var actual = textOperation.GetNameCompare();
            var expected = "Palindrom";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckAnagram()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("dzielenia", "niedziela")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "dzielenia", "niedziela");
            var actual = textOperation.GetNameCompare();
            var expected = "Anagram";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckWordsWithDifferentLegnths()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("ewcia", "ewa")).Returns(false);
            var textOperation = new TextOperation(mock.Object, "ewcia", "ewa");
            //Assert
            Assert.Throws<Exception>(() => textOperation.GetNameCompare());

        }

        [Test]
        public void CheckDifferentWords()
        {
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("piątek", "sobota")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "piątek", "sobota");
            var actual = textOperation.GetNameCompare();
            var expected = "Brak";
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
