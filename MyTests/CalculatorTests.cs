using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using ApplicationToLearnTest;
using NUnit.Framework;
using System.Security.Cryptography;
using NUnit.Framework.Constraints;

namespace MyTests
{
    internal class CalculatorTests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
            Assert.IsInstanceOf(typeof(Calculator), calculator);
        }

 
        #region Dodawanie
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Add(5, 4);
            var expected = 9;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Add(-2, -2);
            var expected = -4;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPositiveNegative()
        {
            //Act
            var actual = calculator.Add(2, -3);
            var expected = -1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNegativePositive()
        {
            //Act
            var actual = calculator.Add(-5, 10);
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(5, 6, 11)]
        [TestCase(-3, -4, -7)]
        [TestCase(5, -6, -1)]
        [TestCase(-5, 6, 1)]
        public void CheckAdd(int number1, int number2, int expected)
        {
            //Act
            var actual = calculator.Add(number1, number2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region Odejmowanie
        [Test]

        public void SubstructPositiveNegativeNumbers()
        {
            //Act
            var actual = calculator.Substruct(5, -4);
            var expected = 9;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Substruct(-2, -5);
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Substruct(2, 3);
            var expected = -1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructNegativePositiveNumbers()
        {
            //Act
            var actual = calculator.Substruct(-4, -6);
            var expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructNegativePositive()
        {
            //Act
            var actual = calculator.Substruct(-3, 3);
            var expected = -6;
            //Assert
            Assert.AreEqual(actual, expected);
        }
        #endregion
        #region Dzielenie

        [Test]

        public void DividePositiveByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(8, 0));
        }

        [Test]
        public void DivideNegativeByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-8, 0));
        }

        [Test]
        public void DivideNegativePositive()
        {
            //Act
            var actual = calculator.Divide(-6, 3);
            var expected = -2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveNegative()
        {
            //Act
            var actual = calculator.Divide(6, -2);
            var expected = -3;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositivePositive()
        {
            //Act
            var actual = calculator.Divide(10, 2);
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativeNegative()
        {
            //Act
            var actual = calculator.Divide(-10, -5);
            var expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region Mnożenie

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Multiply(2, 3);
            var expected = 6;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Multiply(-3, -3);
            var expected = 9;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyNegativePositive()
        {
            //Act
            var actual = calculator.Multiply(-3, 2);
            var expected = -6;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyPositiveNegative()
        {
            //Act
            var actual = calculator.Multiply(3, -2);
            var expected = -6;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    

        #endregion

    }
}
