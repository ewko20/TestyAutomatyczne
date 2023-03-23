using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class PasswordTests
    {
        Randomize randomize;

        [SetUp]
        public void Setup()
        {
            randomize = new Randomize(new Random());
            Assert.IsInstanceOf(typeof(Randomize), randomize);

        }

        [Test]
        public void CorrectPassword()
        {
            var pass = new Pass(randomize, true, true, 4, 2);
            var actual = pass.CheckPassword();
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void TooShortPassword()
        {
            var pass=new Pass(randomize, true,true,3,2);
            var actual = pass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutCapitalLetter()
        {
            var pass = new Pass(randomize, true, true, 6, 0);
            var actual=pass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutSpecialCharacter()
        {
            var pass = new Pass(randomize, true, false, 3, 4);
            var actual = pass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutDigit()
        {
            var pass = new Pass(randomize, false, true, 3, 4);
            var actual = pass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutSmallLetter()
        {
            var pass = new Pass(randomize, true, true, 0, 6);
            var actual= pass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }
       

    }
}
