using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using Moq;

namespace MyTests
{
    internal class PassTests
    {
        [Test]
        public void CheckCorrectPassword()
        {
            var mock = new Mock<IRandomize>();
            mock.Setup(m => m.RandomPassword(true, true, 2, 4)).Returns("Ewunia@1");
            var pass = new Pass(mock.Object, true, true, 2, 4);
            var actual = pass.CheckPassword();
            //Assert
            Assert.IsTrue(actual);

        }


    }
}
