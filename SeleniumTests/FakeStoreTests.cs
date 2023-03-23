using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    internal class FakeStoreTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://fakestore.testelka.pl";
        }

        [Test]
        public void CreateNewAccount()
        {
            var myAccountLink = driver.FindElement(By.Id("menu-item-201"));
            myAccountLink.Click();
            var email = driver.FindElement(By.Id("reg_email"));
            email.Clear();
            email.SendKeys("testewa@interia.pl");
            var password = driver.FindElement(By.Id("reg_password"));
            password.Clear();
            password.SendKeys("testpassword1!");
            var regButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/article/div/div/div[2]/div[2]/form/p[3]/button"));
            regButton.Click();
            var expected = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/article/div/div/div/p[1]")).Text;
            Assert.IsTrue(expected.Contains("Witaj"));

        }

        [Test]
        public void BuyProducts()
        {
            //driver.Url = "https://fakestore.testelka.pl/product/egipt-el-gouna/";
            var shopLink = driver.FindElement(By.Id("menu-item-198"));
            shopLink.Click();
            var windsurfingButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a/img"));
            windsurfingButton.Click();
            Thread.Sleep(2000);
            var egipElGounaButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a[2]"));
            egipElGounaButton.Click();
            var goToCart = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a[3]"));
            goToCart.Click();
            var quantityTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/main/div[2]/div[2]/form/div/input"));
            quantityTextBox.Clear();
            quantityTextBox.SendKeys("2");
            var addToCart = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/main/div[2]/div[2]/form/button"));
            addToCart.Click();
            var seeCart = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/a"));
            seeCart.Click();
            var proceedToPayment = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/article/div/div/div[2]/div/div/a"));
            proceedToPayment.Click();
            var firstName = driver.FindElement(By.Id("billing_first_name"));
            firstName.Clear();
            firstName.SendKeys("Jan");
            var lastName = driver.FindElement(By.Id("billing_last_name"));
            lastName.Clear();
            lastName.SendKeys("Kowalski");
            var countryList = driver.FindElement(By.Id("select2-billing_country-container"));
            countryList.Click();
            var poland = driver.FindElement(By.Id("select2-billing_country-result-hipk-PL"));
            poland.Click();
            var postCode = driver.FindElement(By.Id("billing_postcode"));
            postCode.Clear();
            postCode.SendKeys("00-011");
            var city = driver.FindElement(By.Id("billing_city"));
            city.Clear();
            city.SendKeys("Białystok");
            var phone = driver.FindElement(By.Id("billing_phone"));
            phone.Clear();
            phone.SendKeys("123456789");
            var email = driver.FindElement(By.Id("billing_email"));
            email.Clear();
            email.SendKeys("testewa@interia.pl");
            var street = driver.FindElement(By.Id("billing_address_1"));
            street.Clear();
            street.SendKeys("Lipowa 2/1");
            var cardNumber = driver.FindElement(By.XPath("/html/body/div/form/span[2]/div/div[2]/span/input"));
            cardNumber.Clear();
            cardNumber.SendKeys("4242424242424242");
            var expiryDate = driver.FindElement(By.XPath("/html/body/div/form/span[2]/span/input"));
            expiryDate.Clear();
            expiryDate.SendKeys("12/23");
            var cvcCode = driver.FindElement(By.XPath("/html/body/div/form/span[2]/span/input"));
            cvcCode.Clear();
            cvcCode.SendKeys("000");
            var termsCheckBox = driver.FindElement(By.Id("terms"));
            termsCheckBox.Click();
            var buyButton = driver.FindElement(By.Id("place_order"));
            buyButton.Click();
            var actual = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/main/article/header/h1")).Text;
            var expected = "Zamówienie otrzymane";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SortElementsAscendingPrice()
        {
            var shopLink = driver.FindElement(By.Id("menu-item-198"));
            shopLink.Click();
            var windsurfingButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a/img"));
            windsurfingButton.Click();
            var selectList = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/div[1]/form/select"));
            selectList.Click();
            var sortAsc = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/div[1]/form/select/option[5]"));
            sortAsc.Click();
            var actual = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]")).Text;
            var expected = "Windsurfing w Karpathos";
            Assert.IsTrue(actual.Contains(expected));


        }

        [Test]
        public void AddingToCart()
        {
            var shopLink = driver.FindElement(By.Id("menu-item-198"));
            shopLink.Click();
            var windsurfingButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a"));
            windsurfingButton.Click();
            Thread.Sleep(3000);
            var egipElGounaButton = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[2]/a[1]"));
            egipElGounaButton.Click();
            Thread.Sleep(3000);
            var addToCartButton = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/main/div[2]/div[2]/form/button"));
            addToCartButton.Click();
            Thread.Sleep(3000);
            var actual = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div")).Text;
            var expected = "dodany do koszyka";
            Assert.IsTrue(actual.Contains(expected));


        }

        [Test]
        public void AddProductToCart2()
        {
            driver.Url = "https://fakestore.testelka.pl/product/egipt-el-gouna/";
            //var shop = driver.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/div[1]/ul/li[2]/a"));
            //shop.Click();
            //var windsurfing = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a"));
            //windsurfing.Click();
            //Thread.Sleep(3000);
            //var egipt = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a[1]"));
            //egipt.Click();
            // Thread.Sleep(3000);
            var add = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/main/div[2]/div[2]/div[1]/div/a"));
            add.Click();
            Thread.Sleep(3000);
            var info = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div")).Text;
            var expected = "dodany do koszyka";
            Assert.IsTrue(info.Contains(expected));
        }

        [Test]
        public void ZoomingImage()
        {
            driver.Url = "https://fakestore.testelka.pl/product/egipt-el-gouna/";
          //var shop = driver.FindElement(By.XPath("/html/body/div/header/div[2]/div/nav/div[1]/ul/li[2]/a"));
            //shop.Click();
            //var windsurfing = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[1]/a"));
            //windsurfing.Click();
            var addToCard = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/main/div[2]/div[2]/form/button"));
            addToCard.Click();
            Thread.Sleep(3000);
            var seeCart = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/main/ul/li[3]/a[3]"));
            seeCart.Click();
            



        }
    }
}
