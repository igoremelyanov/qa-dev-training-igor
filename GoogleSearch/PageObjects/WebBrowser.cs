﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;


namespace GoogleSearch.PageObjects
{
    [Binding]
    public class WebBrowser
    {
        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {
                    //Select IE browser
                    //ScenarioContext.Current["browser"] = new InternetExplorerDriver();

                    //Select Firefox browser
                    ScenarioContext.Current["browser"] = new FirefoxDriver();

                    //Select Chrome browser
                    //ScenarioContext.Current["browser"] = new ChromeDriver();
                }
                return (IWebDriver)ScenarioContext.Current["browser"];
            }
        }

        [AfterScenario]
        public static void Close()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
            {
                Current.Dispose();
            }
        }
    }

}
