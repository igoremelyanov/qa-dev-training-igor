using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleSearch.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace GoogleSearch.StepDefinitions
{
    [Binding]
    public class ShowLogInNewSmiPageSteps
    {
        [Given(@"Hit the link to NewSMI LogIn page")]
        public void GivenShowUpNewSMILogInPage()
        {
            //Navigate to the site
            WebBrowser.Current.Navigate().GoToUrl("http://devadmin.verrus.com");
        
        }

        
        [Then(@"NewSMI Login suppose to be show up")]
        public void ThenNewSMILoginSupposeToBeShowUp()
        {
            //Check that the Title is what we are expecting
             Assert.AreEqual("Verrus UK Parking Application", WebBrowser.Current.Title);
        }
    }
}
