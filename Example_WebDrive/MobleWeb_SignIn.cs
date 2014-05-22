using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Example_FireFox
{
    [TestFixture]
    public class MobleWeb_SignIn
    {
        IWebDriver driver;
        //or just IWebDriver driver = new FirefoxDriver();
        private string baseUrl;

        [SetUp]
        public void Setup_FireFox()
        {
           driver = new FirefoxDriver();
           baseUrl = "http://devm.paybyphone.co.uk/Default.aspx";
        }

        [TearDown]
        public void TearDown_FireFox()
        {
            driver.Quit();
        }


        [Test]
        public void Testing_Opening_SignIn_MobileWEB_Page_In_FireFox()
        {
            string title = "PayByPhone Mobile";
            driver.Navigate().GoToUrl(baseUrl);
            // Wait for the page to load, timeout after 5 seconds
            //WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //driver.Manage().Timeouts().ImplicitlyWait(30, TimeUnit.SECONDS);
            //driver.Manage().Timeouts().ImplicitlyWait(30);
          //  driver.Manage().Timeouts().SetPageLoadTimeout(0, TimeUnit.SECONDS);

            // Wait for the page to load, timeout after 10 seconds
         // Google's search is rendered dynamically with JavaScript.
        // Wait for the page to load, timeout after 10 seconds

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until((d) => { return d.Title.ToLower().StartsWith("PayByPhone Mobile"); });

            

            //WebDriverWait wait = new WebDriverWait(driver, 10);
            //WebElement element = wait.until(ExpectedConditions.ElementExists(By.id("someid");

            
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            IWebElement myDynamicElement = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_MessageBoxTable_MessageLabel"));

            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(20));
            
            Assert.AreEqual(title, driver.Title);
        }

    }


}
