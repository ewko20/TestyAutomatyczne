using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

namespace SeleniumTests
{
    internal class ZgłoszenieTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
           // driver = new InternetExplorerDriver();
            driver.Url = "https://lamp.ii.us.edu.pl/~mtdyd/zawody/";
        }

        [Test]
        public void AddPersonToAdultWithMinAge()
        {
            var name = driver.FindElement(By.Id("inputEmail3"));
            name.Clear();
            name.SendKeys("Ewa");
            var lastName = driver.FindElement(By.Id("inputPassword3"));
            lastName.Clear();
            lastName.SendKeys("Kowalska");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("11-11-2004");
            var sendButton = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            sendButton.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var actual = driver.FindElement(By.Id("returnSt")).Text;
            var expected = "Dorosly";
            Assert.IsTrue(actual.Contains(expected));
        }

        [Test]
        public void AddPersonToJuniorWithMaxAge()
        {
            var name = driver.FindElement(By.Id("inputEmail3"));
            name.Clear();
            name.SendKeys("Ewa");
            var lastName = driver.FindElement(By.Id("inputPassword3"));
            lastName.Clear();
            lastName.SendKeys("Kowalska");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("11-11-2005");
            var checkBoxParentAgreement = driver.FindElement(By.Id("rodzice"));
            checkBoxParentAgreement.Click();
            var checkBoxDoctorAgreement = driver.FindElement(By.Id("lekarz"));
            checkBoxDoctorAgreement.Click();
            var sendButton = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            sendButton.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var actual = driver.FindElement(By.Id("returnSt")).Text;
            var expected = "Junior";
            Assert.IsTrue(actual.Contains(expected));
        }

        [Test]
        public void AddPersonToSeniorWithMinAge()
        {
            var name = driver.FindElement(By.Id("inputEmail3"));
            name.Clear();
            name.SendKeys("Ewa");
            var lastName = driver.FindElement(By.Id("inputPassword3"));
            lastName.Clear();
            lastName.SendKeys("Kowalska");
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys("11-11-1957");
            var checkBoxDoctorAgreement = driver.FindElement(By.Id("lekarz"));
            checkBoxDoctorAgreement.Click();
            var sendButton = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));
            sendButton.Click();
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Accept();
            var actual = driver.FindElement(By.Id("returnSt")).Text;
            var expected = "Senior";
            Assert.IsTrue(actual.Contains(expected));
        }

        [TearDown] 
        public void QuitSite()
        {
            driver.Quit();
        }

        [Test]
        [TestCase("29-11-2002", "Dorosly", false, false, "Gosia", "Herzog")]
        [TestCase("03-11-1956", "Dorosly", false, false, "Gosia", "Herzog")]
        [TestCase("31-12-1955", "Senior", true, false, "Gosia", "Herzog")]
        [TestCase("31-12-1955", "Blad danych", false, false, "Gosia", "Herzog")]
        [TestCase("29-11-2006", "Junior", true, true, "Gosia", "Herzog")]
        [TestCase("29-11-2003", "Junior", true, true, "Gosia", "Herzog")]
        [TestCase("29-11-2006", "Blad danych", false, false, "Gosia", "Herzog")]
        [TestCase("29-11-2006", "Blad danych", false, true, "Gosia", "Herzog")]
        [TestCase("29-11-2006", "Blad danych", true, false, "Gosia", "Herzog")]
        [TestCase("29-11-2003", "Blad danych", false, false, "Gosia", "Herzog")]
        [TestCase("29-11-2003", "Blad danych", false, true, "Gosia", "Herzog")]
        [TestCase("29-11-2003", "Blad danych", true, false, "Gosia", "Herzog")]
        [TestCase("29-11-2002", "First name must be filled out", false, false, "", "Herzog")]
        [TestCase("29-11-2002", "Nazwisko musi byc wypelnione", false, false, "Gosia", "")]
        [TestCase("", "Data urodzenia nie moze byc pusta", false, false, "Gosia", "Herzog")]
        public void CheckSportCompetition(string age, string expect, bool doctorAgreement, bool parentAgreement, string firstName, string lastName)
        {
            var firstname = driver.FindElement(By.Id("inputEmail3"));
            firstname.Clear();
            firstname.SendKeys(firstName);
            var name = driver.FindElement(By.Id("inputPassword3"));
            name.Clear();
            name.SendKeys(lastName);
            var dateOfBirth = driver.FindElement(By.Id("dataU"));
            dateOfBirth.Clear();
            dateOfBirth.SendKeys(age);
            if (doctorAgreement)
            {
                var doctorAgree = driver.FindElement(By.Id("lekarz"));
                doctorAgree.Click();
            }
            if (parentAgreement)
            {
                var parentsAgree = driver.FindElement(By.Id("rodzice"));
                parentsAgree.Click();
            }
            var button = driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[6]/div/button"));

            button.Click();
            if (firstName == "" || lastName == "" || age == "")
            {
                Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains(expect));
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                driver.SwitchTo().Alert().Accept();
                driver.SwitchTo().Alert().Accept();
                var info = driver.FindElement(By.Id("returnSt"));
                Assert.IsTrue(info.Text.Contains(expect));
            }

        }


    }
}
