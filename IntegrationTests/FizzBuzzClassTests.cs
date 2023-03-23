using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class FizzBuzzClassTests
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
            Assert.IsInstanceOf(typeof(Calculator), calculator);
        }

        [Test]
        public void CheckDividePositiveByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzzClass(calculator, 12, 3);
            var actual = fizzBuzz.CheckFizzBuzz();
            var expected = "FizzBuzz";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckNotDividePositiveByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzzClass(calculator, 1, 3);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz());
        }

    [Test]
    public void CheckDividePositiveByThree()
    {
        var fizzBuzz = new FizzBuzzClass(calculator, 10, 1);
        var actual = fizzBuzz.CheckFizzBuzz();
        var expected = "Fizz";
        //Assert
        Assert.AreEqual(expected, actual);
    }


}
}
