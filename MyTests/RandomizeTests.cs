using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class RandomizeTests
    {
        Randomize randomize;
        [SetUp]
        public void SetUp()
        {
            randomize = new Randomize(new Random());
            //var random = new Random()
            //randomize=new Randomize(random);
        }
        #region Losowanie Liczb
        [Test]
        public void CheckRandomTwoPositiveNumbers()
        {
            //Act
            var actual = randomize.RandomNumber(3, 9);
            //Assert
            Assert.IsTrue(actual >= 3 && actual <= 9);
        }

        [Test]
        public void CheckNotRandomPositiveNegativeNumbers()
        {
            //ActAssert
            Assert.Throws<Exception>(() => randomize.RandomNumber(5, -2));
        }
        #endregion
        #region Losowanie Tekstu
        [Test]
        public void CheckRandomSmallLetters()
        {
            //Act
            var actual = randomize.RandomString(5, true);
            //Assert
            Assert.IsTrue(actual.All(char.IsLower) && actual.Length == 5);
        }

        [Test]
        public void CheckNotRandomText()
        {
            //ActAssert
            Assert.Throws<Exception>(() => randomize.RandomString(-7, true));
        }

        [Test]
        public void CheckRandomBigLetters()
        {
            //Act
            var actual = randomize.RandomString(5, false);
            //Assert
            Assert.IsTrue(actual.All(char.IsUpper) && actual.Length == 5);
        }
        #endregion
        #region Losowanie Hasła

        [Test]
        public void CheckRandomSmallLetterBigLetterNumberSpecialCharacter()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 5, 4);
            //Assert
            Assert.IsTrue(actual.Length == 11 && actual.Any(char.IsDigit) && actual.Any(char.IsLetter) && actual.Any(char.IsLower) && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckRandomPasswordWithoutSmallLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 0, 5);
            //Assert
            Assert.IsTrue(actual.Length == 7 && actual.Any(char.IsDigit) && actual.Any(char.IsLetter) && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit) && !actual.Any(char.IsLower));
        }

        [Test]

        public void CheckRandomPassowordWithoutCapitalLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 6, 0);
            //Assert
            Assert.IsTrue(actual.Length == 8 && actual.Any(char.IsDigit) && actual.Any(char.IsLetter) && actual.Any(char.IsLower) && !actual.All(char.IsLetterOrDigit) && !actual.Any(char.IsUpper));
        }

        [Test]
        public void CheckRandomPasswordWithoutDigits()
        {
            //Act
            var actual = randomize.RandomPassword(false, true, 4, 1);
            //Assert
            Assert.IsTrue(actual.Length == 6 && actual.Any(char.IsLetter) && actual.Any(char.IsUpper) && actual.Any(char.IsLower) && !actual.Any(char.IsDigit));
        }





        #endregion
    }
}
