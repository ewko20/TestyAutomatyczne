using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;

namespace MyTests
{
    internal class CodeTests
    {
        Code code;

        [SetUp]
        public void Setup()
        {
            code = new Code();
            Assert.IsInstanceOf<Code>(code);
        }

        [Test]
        public void CreateESTJ()
        {
            //Act
            var actual = code.GenerateCode(true, true, true, true);
            var expected = "ESTJ";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateINTJ()
        {
            //Act
            var actual=code.GenerateCode(false,false,true,true);
            var expected = "INTJ";
            //Assert
            Assert.AreEqual(expected , actual);
        }

        [Test]
        public void CreateINTP()
        {
            //Act
            var actual=code.GenerateCode(false,false,true,false);
            var expected = "INTP";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateENTJ()
        {
            //Act
            var actual = code.GenerateCode(true, false, true, true);
            var expected = "ENTJ";
            //Assert
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void CreateENTP()
        {
            //Act
            var actual = code.GenerateCode(true, false, true, false);
            var expected = "ENTP";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateINFJ()
        {
            //Act
            var actual = code.GenerateCode(false, false, false, true);
            var expected = "INFJ";
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CreateINFP()
        {
            //Act
            var actual = code.GenerateCode(false, false, false, false);
            var expected = "INFP";
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CreateENFJ()
        {
            //Act
            var actual = code.GenerateCode(true, false, false, true);
            var expected = "ENFJ";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateENFP()
        {
            //Act
            var actual = code.GenerateCode(true, false, false, false);
            var expected = "ENFP";
            //Assert
            Assert.AreEqual(expected , actual);
        }

        [Test]
        public void CreateISTJ()
        {
            //Act
            var actual = code.GenerateCode(false, true, true, true);
            var expected = "ISTJ";
            //Assert
            Assert.AreEqual (expected, actual);
        }

        [Test]
        public void CreateISFJ()
        {
            //Act
            var actual=code.GenerateCode(false,true,false,true);
            var expected = "ISFJ";
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CreateESFJ()
        {
            //Act
            var actual = code.GenerateCode(true, true, false, true);
            var expected = "ESFJ";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateISTP()
        {
            //Act
            var actual = code.GenerateCode(false, true, true, false);
            var expected = "ISTP";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateISFP()
        {
            //Act
            var actual = code.GenerateCode(false, true, false, false);
            var expected = "ISFP";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateESTP()
        {
            //Act
            var actual = code.GenerateCode(true, true, true, false);
            var expected = "ESTP";
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CreateESFP()
        {
            //Act
            var actual = code.GenerateCode(true, true, false, false);
            var expected = "ESFP";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
