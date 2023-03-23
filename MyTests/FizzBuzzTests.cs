using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;

        [SetUp]
        public void Initialize()
        {
            fizzBuzz = new FizzBuzz();
            Assert.IsInstanceOf(typeof(FizzBuzz), fizzBuzz);
        }


        [Test]
        public void CheckDividePositiveByThreeAndFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(15);
            var expected = "FizzBuzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNotDividePositiveNumber()
        {
            //Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(13));
        }

        [Test]

        public void CheckDividePositiveByThree()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(12);
            var expected = "Fizz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDividePositiveByFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(25);
            var expected = "Buzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDivideNegativeByThreeAndFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-15);
            var expected = "FizzBuzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDivideNegativeByThree()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-12);
            var expected = "Fizz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckDivideNegativeByFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-25);
            var expected = "Buzz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void CheckNotDivideNegativeNumbers()
        {
            //Assert
            Assert.Throws<Exception>(()=>fizzBuzz.CheckFizzBuzz(-13));
        }

    }
}
