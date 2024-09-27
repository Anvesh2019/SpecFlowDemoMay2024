using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SpecFlowDemoMay2024.Pages;
using System.Collections;
using System.Collections.Generic;

namespace SpecFlowDemoMay2024.StepDefinitions
{
    [Binding]
    public class TechTutorialzStepDefinitions
    {
        IWebDriver dr;
        GooglePage _gpage = new GooglePage();

        //[Given(@"I navigate to ""([^""]*)""")]
        //public void GivenINavigateTo(string strURL)
        //{
        //   // dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
        //    dr.Navigate().GoToUrl(strURL);
        //    dr.Manage().Window.Maximize();
        //}

        //[When(@"I Search for ""([^""]*)""")]
        //public void WhenISearchFor(string strCourse)
        //{
        //    dr.FindElement(By.Id("s")).SendKeys(strCourse);
        //    dr.FindElement(By.XPath("//button[text()='search']")).Click();
        //}

        [Then(@"I verify Search results displayed")]
        public void ThenIVerifySearchResultsDisplayed()
        {
            IWebElement srchRes = dr.FindElement(By.XPath("(//a[text()='Appium Tutorial'])[2]"));
            Assert.IsTrue(srchRes.Displayed == true, "Search results NOT displayed");
            dr.Close();
        }
        [Given(@"I navigate to Google site")]
        public void GivenINavigateToGoogleSite()
        {
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

            dr.Navigate().GoToUrl("https://google.com");
        }

        //[When(@"I search for India")]
        //public void WhenISearchForIndia()
        //{
        //    dr.FindElement(By.Name("q")).SendKeys("India");
        //    dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        //}

        [Then(@"I verify the test results for google")]
        public void ThenIVerifyTheTestResultsForGoogle()
        {
            
        }
        [Then(@"i click on Search button")]
        public void ThenIClickOnSearchButton()
        {
            dr.FindElement(By.Id("q")).Click();
        }


        [Then(@"I verify search results are displayed")]
        public void ThenIVerifySearchResultsAreDisplayed()
        {
            string url = dr.Url;
            Assert.IsTrue(url.Contains("q=India"),"Search results not displayed for India");
        }
        [Given(@"I navigate to Amazon site")]
        public void GivenINavigateToAmazonSite()
        {
            if(dr==null)
            {
                dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

            }

            dr.Navigate().GoToUrl("https://amazon.in");

        }

        //[When(@"I search for '([^']*)'")]
        //public void WhenISearchFor(string country)
        //{
        //    //dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
        //    //_gpage.txtSrch.SendKeys(country);
        //    dr.FindElement(By.Name("q")).SendKeys(country);
        //    dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        //}

        [Then(@"I verify search results are displayed for '([^']*)'")]
        public void ThenIVerifySearchResultsAreDisplayedFor(string country)
        {
            string url = dr.Url;
            Assert.IsTrue(url.Contains("q=" + country), "Search results not displayed for " + country);
            dr.Close();
        }
        [Given(@"I navigate to <site>")]
        public void GivenINavigateToSite(Table table)
        {
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            var dictionary = new Dictionary<int, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(1,row[0]);
            }
            dr.Navigate().GoToUrl(dictionary[1]);
        }
        [Given(@"I navigate to '([^']*)'")]
        public void GivenINavigateTo(string site, Table table)
        {
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

            var dictionary = new Dictionary<string,string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            //dr.Navigate().GoToUrl(dictionary.Keys[0]);
        }


        [When(@"I search for <keyword>")]
        public void WhenISearchForKeyword(Table table)
        {
            //dr.FindElement(By.Name("q")).SendKeys(table.ToString());
            //dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string strKeyword)
        {
            dr.FindElement(By.Name("q")).SendKeys(strKeyword);
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }
               
    }
}
