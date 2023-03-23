using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace IntegrationTests
{
    internal class PersonalityTests
    {
        Code code;

        [SetUp]
        public void Setup()
        {
            code = new Code();
            Assert.IsInstanceOf(typeof(Code), code);
        }
        [Test]
        public void CheckCreateArchitekt()
        {

            var personality = new Personality(code, false, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Architekt";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckCreateLogik()
        {

            var personality = new Personality(code, false, false, true, false);
            var actual = personality.GetPersonality();
            var expected = "Logik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDowodca()
        {
            var personality = new Personality(code, true, false, true, true);
            var actual = personality.GetPersonality();
            var expected = "Dowódca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDyskutant()
        {
            var personality = new Personality(code, true, false, true, false);
            var actual = personality.GetPersonality();
            var expected = "Dyskutant";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateRzecznik()
        {
            var personality = new Personality(code, false, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Rzecznik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePosrednik()
        {
            var personality = new Personality(code, false, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Pośrednik";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateProtagonista()
        {
            var personality = new Personality(code, true, false, false, true);
            var actual = personality.GetPersonality();
            var expected = "Protagonista";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDzialacz()
        {
            var personality = new Personality(code, true, false, false, false);
            var actual = personality.GetPersonality();
            var expected = "Działacz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateLogistyk()
        {
            var personality = new Personality(code, false, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Logistyk";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateObronca()
        {
            var personality = new Personality(code, false, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Obrońca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateWykonawca()
        {
            var personality = new Personality(code, true, true, true, true);
            var actual = personality.GetPersonality();
            var expected = "Wykonawca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateDoradca()
        {
            var personality = new Personality(code, true, true, false, true);
            var actual = personality.GetPersonality();
            var expected = "Doradca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateWirtuoz()
        {
            var personality = new Personality(code, false, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Wirtuoz";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePoszukiwaczPrzygod()
        {
            var personality = new Personality(code, false, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Poszukiwacz przygód";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreatePrzedsiebiorca()
        {
            var personality = new Personality(code, true, true, true, false);
            var actual = personality.GetPersonality();
            var expected = "Przedsiębiorca";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckCreateAnimator()
        {
            var personality = new Personality(code, true, true, false, false);
            var actual = personality.GetPersonality();
            var expected = "Animator";
            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
