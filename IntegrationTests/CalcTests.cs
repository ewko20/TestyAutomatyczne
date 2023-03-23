using ApplicationToLearnTest;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class CalcTests
    {
        Randomize randomize;

        [SetUp]
        public void Setup()
        {
            //var random = new Random();
            //randomize = new Randomize(random);// można albo dwie pierwsze linijki, albo tą poniżej. Jedno i drugi poprawne
            randomize = new Randomize(new Random());
            Assert.IsInstanceOf(typeof(Randomize),randomize);
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            var calculator = new Calc(2, 100,1,150,randomize,randomize);
            var actual = calculator.Add();
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 250);

        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            var calculator=new Calc(-100,-1,-100,-1,randomize,randomize);
            var actual = calculator.Multiply();
            //Assert
            Assert.IsTrue(actual <= 10000 && actual >= 1);
        }

        [Test]
        public void DivideNegativeByZeroException()
        {
            var calculator=new Calc(-5,-1,0,0,randomize,randomize);
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }




    }
}
