using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlowDemoMay2024.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions : BaseStepDefinitions
    {
        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string strURL)
        {
            dr.Navigate().GoToUrl(strURL);
            dr.Manage().Window.Maximize();
        }
        [Then(@"i verified results")]
        public void ThenIVerifiedResults()
        {
           
        }

        [When(@"I click on ""([^""]*)"" link")]
        public void WhenIClickOnLink(string strLink)
        {
           
            dr.FindElement(By.LinkText(strLink)).Click();
        }

        [Then(@"I verify related page is loaded")]
        public void ThenIVerifyRelatedPageIsLoaded()
        {
            string strTitle = dr.Title;
            Assert.IsTrue(strTitle.Contains("Help"));
        }


        [When(@"I search for item '([^']*)'")]
        public void WhenISearchForItem(string strItem)
        {
            dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys(strItem);
            dr.FindElement(By.Id("nav-search-submit-button")).Click();

        }

        [Then(@"I verify '([^']*)' results are displayed")]
        public void ThenIVerifyResultsAreDisplayed(string strResults)
        {
            string title = dr.Title;
            Assert.IsTrue(title.Contains(strResults), "Search results are not displayed");

        }


    }
}
