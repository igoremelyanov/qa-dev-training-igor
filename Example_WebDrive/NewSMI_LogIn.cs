using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Example_FireFox
{
    [TestFixture]
    public class NewSMI_LogIn
    {
         IWebDriver driver;
        //or just IWebDriver driver = new FirefoxDriver();
        private string baseUrl;

        [SetUp]
        public void Setup_FireFox()
        {
            driver = new FirefoxDriver();
            baseUrl = "http://devadmin.verrus.com/newsmi/system/login";
        }

        [TearDown]
        public void TearDown_FireFox()
        {
            driver.Quit();
        }

        [Test]
        public void Testing_Opening_LoginIn_NewSMI_Page_In_FireFox()
        {
            string title = "Login";
            driver.Navigate().GoToUrl(baseUrl);
            Assert.AreEqual(title, driver.Title);
        }

    }
}
