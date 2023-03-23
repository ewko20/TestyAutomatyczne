using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class PasswordClassTests
    {
        [Test]
        public void SetUp()
        {
            var password = new Password();
            Assert.IsInstanceOf(typeof(Password), password);
        }
        [Test]
        public void CorrectPassword()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "Ewunia@1"
            };
            //Act
            var actual = password.CheckPassword();
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void TooShortPassword()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "Ewcia@1"
            };
            //Act
            var actual = password.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutCapitalLetter()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "ewunia@1"
            };
            //Act
            var actual = password.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutSmallLetter()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "EWUNIA@1"
            };
            //Act
            var actual = password.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutNumber()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "Ewuniaa@"
            };

            //Act
            var actual=password.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutSpecialCharacter()
        {
            //Arrange
            var password = new PasswordClass()
            {
                MyPassword = "Ewuniaa1"
            };
            //Act
            var actual = password.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }



    }
}
