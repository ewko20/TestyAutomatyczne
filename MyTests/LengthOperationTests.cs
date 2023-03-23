using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class LengthOperationTests
    {
        LengthOperation lengthOperation;

        [SetUp]
        public void Setup()
        {
            lengthOperation = new LengthOperation();
            Assert.IsInstanceOf<LengthOperation>(lengthOperation);
        }

        [Test]
        public void CheckAreEqual()
        {
            //Act
            var actual = lengthOperation.CompareLength("ola", "ala");
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckAreNotEqual()
        {
            //Act
            var actual = lengthOperation.CompareLength("ewa", "adam");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckException1()
        {
            //Assert
            Assert.Throws<Exception>(() => lengthOperation.CompareLength(null, "ewa"));
        }

        [Test]
        public void CheckException2()
        {
            //Assert
            Assert.Throws<Exception>(() => lengthOperation.CompareLength("ewa",null));
        }
    }
}
