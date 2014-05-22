using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleSearch.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace GoogleSearch
{
    [Binding]
    public class GoogleSearchDefenitions
    {
        [Given(@"I am on Google home page")]
        public void GivenIAmOnGogleHomePage()
        {
            //Navigate to the site
            WebBrowser.Current.Navigate().GoToUrl("http://www.google.com");
            //Check that the Title is what we are expecting
            Assert.AreEqual("Google", WebBrowser.Current.Title);
        }

        [When(@"I search for text ""(.*)""")]
        public void WhenISearchForTextSelenium(string keyword)
        {
            // Find the text input element by its name
            IWebElement query = WebBrowser.Current.FindElement(By.Name("q"));
            // Input the search text
            query.SendKeys(keyword);
            // Now submit the form
            query.Submit();

            // Google's search is rendered dynamically with JavaScript.
            // Wait for the page to load, timeout after 5 seconds
            WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));
            IWebElement title = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.ClassName("ab_button"));
            });

            //Just Wait
            Wait_10_seconds();

        }

        [Then(@"I sholud see the search results")]
        public void ThenISholudSeeTheSearchResults()
        {
            //Check that the Title is what we are expecting
            Assert.AreEqual("selenium - Google Search", WebBrowser.Current.Title);
        }

        [Given(@"I wait 10 seconds")]
        [When(@"I wait 10 seconds")]
        [Then(@"I wait 10 seconds")]
        public void Wait_10_seconds()
        {
            System.Threading.Thread.Sleep(10000);
        }


    }
}
