using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoMay2024.StepDefinitions
{
    [Binding]
    public class GoogleStepDefinitions: BaseStepDefinitions
    {
     //   IWebDriver dr;

        public GoogleStepDefinitions()
        {
       //     dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

        }
        [Given(@"I navigate to https://Abhibus\.com")]
        public void GivenINavigateToHttpsAbhibus_Com()
        {
        }

        [When(@"I searched ticket from Hyderabad to Chirala")]
        public void WhenISearchedTicketFromHyderabadToChirala()
        {
            throw new PendingStepException();
        }

        [Then(@"I verify search results")]
        public void ThenIVerifySearchResults()
        {
            throw new PendingStepException();
        }

        [When(@"I entered ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIEnteredAnd(string userid, string password)
        {
            throw new PendingStepException();
        }
        [When(@"I search for Sony")]
        public void WhenISearchForSony()
        {
            throw new PendingStepException();
        }

        [Then(@"I verify search results are displayed for Sony")]
        public void ThenIVerifySearchResultsAreDisplayedForSony()
        {
            throw new PendingStepException();
        }
        [When(@"I search for TV '([^']*)'")]
        public void WhenISearchForTV(string tvModel)
        {
            dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys(tvModel);
            
        }

        [Then(@"I verify search results are displayed for TV '([^']*)'")]
        public void ThenIVerifySearchResultsAreDisplayedForTV(string sony)
        {
            
        }

        [When(@"I searched for ""([^""]*)""")]
        public void WhenISearchFor(string strKeyword)
        {
            dr.FindElement(By.Name("q")).SendKeys(strKeyword);
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        [Then(@"I verify the search results")]
        public void ThenIVerifyTheSearchResults()
        {
           
        }
       


    }
}
