using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using Moq;
using System.Net.Http.Headers;

namespace MyTests
{
    internal class CalcTests
    {



        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Arrange
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(2, 10)).Returns(5);
            mock2.Setup(m => m.RandomNumber(1, 9)).Returns(7);
            var calculator = new Calc(2, 10, 1, 9, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = 12;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckDividePositiveNumberByZero()
        {
            //Arrange
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(2, 9)).Returns(5);
            mock2.Setup(m => m.RandomNumber(-1, 100)).Returns(0);
            var calculator = new Calc(2, 9, -1, 100, mock1.Object, mock2.Object);
            //ActAssert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());

        }

        [Test]
        public void CheckAddTwoNegativeNumbers()
        {
            //Arrange
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(-10, -1)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(-100, -50)).Returns(-70);
            var calculator = new Calc(-10, -1, -100, -50, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = -75;
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(expected == actual);//mozna pierwszy lub drugi Assert
        }

        [Test]
        public void CheckAddTwoPositiveNumbers()
        {
            //Arrange
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(0, 100)).Returns(5);
            mock2.Setup(m => m.RandomNumber(0, 100)).Returns(10);
            var calculator = new Calc(0, 100, 0, 100, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = 15;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckAddPositiveNegativeNumber()
        {
            //Arrange
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(1, 50)).Returns(5);
            mock2.Setup(m => m.RandomNumber(-1, -50)).Returns(-10);
            var calculator = new Calc(1, 50, -1, -50, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = -5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckAddNegativePositiveNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(-100, -10)).Returns(-5);
            mock2.Setup(m => m.RandomNumber(1, 100)).Returns(10);
            var calculator = new Calc(-100, -10, 1, 100, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = 5;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckAddPositiveNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(1, 100)).Returns(20);
            mock2.Setup(m => m.RandomNumber(-100, -1)).Returns(-30);
            var calculator = new Calc(1, 100, -100, -1, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Add();
            var expected = -10;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSubtructTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(1, 100)).Returns(20);
            mock2.Setup(m => m.RandomNumber(1, 100)).Returns(10);
            var calculator = new Calc(1, 100, 1, 100, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Substruct();
            var expected = 10;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckSubtructNegativePositiveNumbers()

        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(-100, 100)).Returns(-10);
            mock2.Setup(m => m.RandomNumber(1, 100)).Returns(10);
            var calculator = new Calc(1, -100, 1, 100, mock1.Object, mock2.Object);
            //Assert
            var actual = calculator.Substruct();
            var expected = -10;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSubtructTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(-100, -1)).Returns(-20);
            mock2.Setup(m => m.RandomNumber(-100, -1)).Returns(-10);
            var calculator = new Calc(-100, -1, -100, -1, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Substruct();
            var expected = -10;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckSubtructPositiveNegativeNumber()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(1, 100)).Returns(20);
            mock2.Setup(m => m.RandomNumber(-1, -100)).Returns(-10);
            var calculator = new Calc(1, 100, -1, -100, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Substruct();
            var expected = 30;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideTwoPositiveNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m => m.RandomNumber(1, 100)).Returns(30);
            mock2.Setup(m => m.RandomNumber(1, 100)).Returns(2);
            var calculator = new Calc(1, 100, 1, 100, mock1.Object, mock2.Object);
            //Act
            var actual = calculator.Divide();
            var expected = 15;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideTwoNegativeNumbers()
        {
            var mock1 = new Mock<IRandomize>();
            var mock2 = new Mock<IRandomize>();
            mock1.Setup(m=>m.RandomNumber(-100,-1)).Returns(-30);
            mock2.Setup(m => m.RandomNumber(-100, -1)).Returns(-2);
            var calculator = new Calc(-100,-1,-100,-1,mock1.Object,mock2.Object);
            //Act
            var actual = calculator.Divide();
            var expected = 15;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
