using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class CalculatorClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 2,
                Number2 = 3
            };
            Assert.IsInstanceOf(typeof(CalculatorClass), calculator);
        }
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 2,
                Number2 = 3
            };
            //Act
            var actual = calculator.Add();
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -2,
                Number2 = -3
            };
            //Act
            var actual = calculator.Add();
            var expected = -5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNegativePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -2,
                Number2 = 2
            };
            //Act
            var actual = calculator.Add();
            var expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPositiveNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
                {
                Number1 = 2,
                Number2 = -4
            };
            //Act
            var actual = calculator.Add();
            var expected = -2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveByZero()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 5,
                Number2 = 0
            };
            //ActAssert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }

        [Test]
        public void DivideNegativeByZero()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -5,
                Number2 = 0
            };
            //ActAssert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }

        [Test]
        public void SubstructPositivePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 5,
                Number2 = 3
            };
            //Act
            var actual=calculator.Substruct();
            var expected = 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructNegativeNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -5
            };
            //Act
            var actual=calculator.Substruct();
            var expected = -5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructNegativePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 5,
            };
            //Act
            var actual=calculator.Substruct();
            var expected = -15;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructPositiveNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 3,
                Number2 = -4
            };
            //Act
            var actual=calculator.Substruct();
            var expected = 7;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyPositivePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 3,
                Number2 = 3
            };
            //Act
            var actual = calculator.Multiply();
            var expected = 9;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyNegativeNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -2,
                Number2 = -2
            };
            //Act
            var actual=calculator.Multiply();
            var expected = 4;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyNegativePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -2,
                Number2 = 2
            };
            //Act
            var actual=calculator.Multiply();
            var expected = -4;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyPositiveNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 2,
                Number2 = -3
            };
            //Act
            var actual=calculator.Multiply();
            var expected = -6;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 2
            };
            //Act
            var actual=calculator.Divide();
            var expected = -5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = -2
            };
            //Act
            var actual=calculator.Divide();
            var expected= -5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositivePositive()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2
            };
            //Act
            var actual=calculator.Divide();
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativeNegative()
        {
            //Arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -2
            };
            //Act
            var actual = calculator.Divide();
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
