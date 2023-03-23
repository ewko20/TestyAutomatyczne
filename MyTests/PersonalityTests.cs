using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using Moq;

namespace MyTests
{
    internal class PersonalityTests
    {
        [Test]
        public void Setup()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("INTJ");
            var personality = new Personality(mock.Object, false, false, true, true);
            Assert.IsInstanceOf(typeof(Personality), personality);
        }

        [Test]
        public void CreateArchitekt()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("INTJ");
            var personality = new Personality(mock.Object, false, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Architekt";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckCreatingLogik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, false)).Returns("INTP");
            var personality = new Personality(mock.Object, false, false, true, false);
            var actual = personality.GetPersonality();
            var expected = "Logik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatingDowódca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, true, true)).Returns("ENTJ");
            var personality = new Personality(mock.Object, true, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Dowódca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDyskutant()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, true, false)).Returns("ENTP");
            var personality = new Personality(mock.Object, true, false, true, false);
            var actual = personality.GetPersonality();
            var expected = "Dyskutant";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateRzecznik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, true)).Returns("INFJ");
            var personality = new Personality(mock.Object, false, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Rzecznik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePośrednik()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, false)).Returns("INFP");
            var personality = new Personality(mock.Object, false, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Pośrednik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateProtagonista()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, true)).Returns("ENFJ");
            var personality = new Personality(mock.Object, true, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Protagonista";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDziałacz()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, false)).Returns("ENFP");
            var personality = new Personality(mock.Object, true, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Działacz";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckCreateLogistyk()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, true)).Returns("ISTJ");
            var personality = new Personality(mock.Object, false, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Logistyk";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateObrońca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, true)).Returns("ISFJ");
            var personality = new Personality(mock.Object, false, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Obrońca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateWykonawca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("ESTJ");
            var personality = new Personality(mock.Object, true, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Wykonawca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDoradca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, true)).Returns("ESFJ");
            var personality = new Personality(mock.Object, true, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Doradca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateWirtuoz()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, false)).Returns("ISTP");
            var personality = new Personality(mock.Object, false, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Wirtuoz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePoszukiwaczPrzygód()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, false)).Returns("ISFP");
            var personality = new Personality(mock.Object, false, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Poszukiwacz przygód";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePrzedsiębiorca()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, false)).Returns("ESTP");
            var personality = new Personality(mock.Object, true, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Przedsiębiorca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateAnimator()
        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("ESFP");
            var personality = new Personality(mock.Object, true, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Animator";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}
