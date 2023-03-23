using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumTests
{
    internal class BajerTests
    {
        public string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void SetUp()
        {
            if (DesktopSession == null)
            {
                AppiumOptions appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", @"C:\Users\ewako\Desktop\TESTY\ApiumTestsProject.exe");
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appiumOptions);
            }

            Thread.Sleep(2000);
            Assert.IsNotNull(DesktopSession);
        }

        [TearDown]
        public void Close()
        {
            //DesktopSession.Close();
        }

     

        [Test]
        public void CheckWelcomeEmptyString()
        {
            var textBox = DesktopSession.FindElementByAccessibilityId("tbName");
            textBox.Clear();
            var buttonPowitanie = DesktopSession.FindElementByAccessibilityId("btnHello");
            buttonPowitanie.Click();
            var result= DesktopSession.FindElementByAccessibilityId("lblHello").Text;
            var expected = "Hello World";
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void CheckWelcomeFemale()
        {
            var textBox = DesktopSession.FindElementByAccessibilityId("tbName");
            textBox.Clear();
            textBox.SendKeys("a");
            var checkBox = DesktopSession.FindElementByAccessibilityId("chbBajer");
            checkBox.Click();
            var buttonPowitanie = DesktopSession.FindElementByAccessibilityId("btnHello");
            buttonPowitanie.Click();
            var result = DesktopSession.FindElementByAccessibilityId("lblHello").Text;
            var expected = $"Cześć {textBox.Text} fajna z Ciebie laska!";
            Assert.IsTrue(result.Contains(expected));
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void CheckWelcome()
        {
            var textBox = DesktopSession.FindElementByAccessibilityId("tbName");
            textBox.Clear();
            textBox.SendKeys("Ewa");
            var buttonPowitanie = DesktopSession.FindElementByAccessibilityId("btnHello");
            buttonPowitanie.Click();
            var result = DesktopSession.FindElementByAccessibilityId("lblHello").Text;
            var expected = $"Cześć {textBox.Text}";
            Assert.IsTrue(result.Contains(expected));
            Assert.AreEqual(expected, result);

        }

    }
}
