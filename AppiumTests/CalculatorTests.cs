using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumTests
{
    internal class CalculatorTests
    {
        public string DriverUrl = "http://127.0.0.1:4723/";
        public WindowsDriver<WindowsElement> DesktopSession;

        [SetUp]
        public void SetUp()
        {
            if (DesktopSession == null)
            {
                AppiumOptions appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", @"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                DesktopSession = new WindowsDriver<WindowsElement>(new Uri(DriverUrl), appiumOptions);
            }

            Assert.IsNotNull(DesktopSession);
        }

        [TearDown]
        public void Close()
        {
            DesktopSession.Close();
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            var buttonOne = DesktopSession.FindElementByAccessibilityId("num1Button");
            buttonOne.Click();
            var buttonFive = DesktopSession.FindElementByAccessibilityId("num5Button");
            buttonFive.Click();
            var buttonPlus = DesktopSession.FindElementByAccessibilityId("plusButton");
            buttonPlus.Click();
            var buttonTwo = DesktopSession.FindElementByAccessibilityId("num2Button");
            buttonTwo.Click();
            buttonTwo.Click();
            var buttonEqual = DesktopSession.FindElementByAccessibilityId("equalButton");
            buttonEqual.Click();
            var result = DesktopSession.FindElementByAccessibilityId("CalculatorResults").Text;
            var expected = "37";
            Assert.IsTrue(result.Contains(expected));

        }

        [Test]
        public void DividePositiveByZero()
        {
            var buttonSeven = DesktopSession.FindElementByAccessibilityId("num7Button");
            buttonSeven.Click();
            var buttonDivide = DesktopSession.FindElementByAccessibilityId("divideButton");
            buttonDivide.Click();
            var buttonZero = DesktopSession.FindElementByAccessibilityId("num0Button");
            buttonZero.Click();
            var buttonEqual = DesktopSession.FindElementByAccessibilityId("equalButton");
            buttonEqual.Click();
            var result= DesktopSession.FindElementByAccessibilityId("CalculatorResults").Text;
            var expected = "Nie można dzielić przez zero";
            Assert.IsTrue(result.Contains(expected));
        }
    }




}
