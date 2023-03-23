using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class FizzClassTests
    {
        [Test]
        public void CheckCreatingObject()
        {
            var fizzClass = new FizzClass(15);
            Assert.IsInstanceOf(typeof(FizzClass), fizzClass);
        }

        [Test]
        public void DividePositiveByThreeAndFive()
        {
            //Arrange
            var fizzClass = new FizzClass(15);
            //Act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "FizzBuzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNotDividePositive()
        {
            //Arrange
            var fizzClass = new FizzClass(14);
            //AssertAct
            Assert.Throws<Exception>(() => fizzClass.CheckFizzBuzz());

        }

        [Test]
        public void CheckDividePositiveByThree()
        {
            //Arrange
            var fizzclass = new FizzClass(12);
            //Act
            var actual = fizzclass.CheckFizzBuzz();
            var expected = "Fizz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDividePositiveByFive()
        {
            //Arrange
            var fizzclass = new FizzClass(25);
            //Act
            var actual = fizzclass.CheckFizzBuzz();
            var expected = "Buzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativebyThreeAndFive()
        {
            //Arrange
            var fizzclass = new FizzClass(-15);
            //Act
            var actual = fizzclass.CheckFizzBuzz();
            var expected = "FizzBuzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativeByThree()
        {
            //Arrange
            var fizzclass = new FizzClass(-12);
            //Act
            var actual = fizzclass.CheckFizzBuzz();
            var expected = "Fizz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativeByFive()
        {
            //Arrange
            var fizzclass = new FizzClass(-10);
            //Act
            var actual = fizzclass.CheckFizzBuzz();
            var expected = "Buzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNotDivideNegativeByThreeAndFive()
        {
            //Arrange
            var fizzlcass = new FizzClass(7);
            //ActAssert
            Assert.Throws<Exception>(() => fizzlcass.CheckFizzBuzz());

        }

    }
}
