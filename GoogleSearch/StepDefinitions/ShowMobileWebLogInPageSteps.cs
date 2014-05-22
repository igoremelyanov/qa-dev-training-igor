using System;
using GoogleSearch.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GoogleSearch.StepDefinitions
{
    [Binding]
    public class ShowMobileWebLogInPageSteps
    {
        [Given(@"Hit the link to MobileWeb LogIn page")]
        public void GivenHitTheLinkToMobileWebLogInPage()
        {
            //Navigate to the site
            WebBrowser.Current.Navigate().GoToUrl("http://m.paybyphone.co.uk");
        }


        [Then(@"MobileWeb Login suppose to be show up")]
        public void ThenMobileWebLoginSupposeToBeShowUp()
        {
            //Check that the Title is what we are expecting
            Assert.AreEqual("PayByPhone Mobile", WebBrowser.Current.Title);
        }


    }
}
