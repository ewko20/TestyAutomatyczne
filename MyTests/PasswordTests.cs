using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class PasswordTests
    {
        Password password;

        [SetUp]
        public void Initialize()
        {
            password = new Password();
        }

        [Test]
        public void CorrectPassword()
        {
            //Act
            var actual = password.CheckPassword("Ewunia@1");
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void TooShortPassword()
        {
            //Act
            var actual = password.CheckPassword("Ewcia@1");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]

        public void PasswordWithoutSmallLetter()
        {
            //Act
            var actual = password.CheckPassword("EWUNIA@1");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutCaptialLetter()
        {
            //Act
            var actual = password.CheckPassword("ewunia@1");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutFigure()
        {
            //Act
            var actual = password.CheckPassword("Ewuniaa@");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void PasswordWithoutSpecialCharacter()
        {
            //Act
            var actual = password.CheckPassword("Ewuniaa@");
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
