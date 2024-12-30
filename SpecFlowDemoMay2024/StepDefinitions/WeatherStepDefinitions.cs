using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace SpecFlowDemoMay2024.StepDefinitions
{
    [Binding]
    public class WeatherStepDefinitions 
    {
        IWebDriver dr;
        public string expectedCity = "";

        [Given(@"I navigate to weather site ""([^""]*)""")]
        public void GivenINavigateToWeatherSite(string strSiteURL)
        {
            dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr.Navigate().GoToUrl(strSiteURL);
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }


        [When(@"I searched weather for ""([^""]*)"" zipcode")]
        public void WhenISearchedWeatherForZipcode(string strZip)
        {
            IWebElement txtZip = dr.FindElement(By.XPath("//input[@data-testid='searchModalInputBox']"));
            Actions action = new Actions(dr);
            action.MoveToElement(txtZip).Build().Perform();

            txtZip.SendKeys(strZip);
            Thread.Sleep(3000);
            IWebElement linkCity = null;
            
            if (strZip=="502032")
            {
                linkCity= dr.FindElement(By.XPath("//button[contains(text(),'Ramachandra Puram')]"));
                expectedCity = "Ramachandra Puram";
            }
            else if(strZip=="500085")
            {
                linkCity = dr.FindElement(By.XPath("//button[contains(text(),'Kukatpally')]"));
                expectedCity = "Kukatpally";
            }
            action.ScrollToElement(linkCity).Build().Perform();
            Thread.Sleep(1000);
            linkCity.Click();
            Thread.Sleep(2000);
        }

        [Then(@"I very results")]
        public void ThenIVeryResults()
        {
            //Console.WriteLine("result city name is:" + resultCity);
            IWebElement resultCity = dr.FindElement(By.XPath("//h1[contains(text(),'"+ expectedCity +"')]"));
            Assert.IsTrue(resultCity.Displayed == true, "Wrong results displayed");
            dr.Close();
        }
        [When(@"I searched weather for '([^']*)'")]
        public void WhenISearchedWeatherFor(string strZip)
        {
            IWebElement txtZip = dr.FindElement(By.XPath("//input[@data-testid='searchModalInputBox']"));
            Actions action = new Actions(dr);
            action.MoveToElement(txtZip).Build().Perform();

            txtZip.SendKeys(strZip);
            Thread.Sleep(3000);
            IWebElement linkCity = null;

            if (strZip == "502032")
            {
                linkCity = dr.FindElement(By.XPath("//button[contains(text(),'Ramachandra Puram')]"));
                expectedCity = "Ramachandra Puram";
            }
            else if (strZip == "500085")
            {
                linkCity = dr.FindElement(By.XPath("//button[contains(text(),'Kukatpally')]"));
                expectedCity = "Kukatpally";
            }
            else
            {
                linkCity = dr.FindElement(By.XPath("//button[contains(text(),'Cockeysville')]"));
                expectedCity = "Cockeysville";

            }
            action.ScrollToElement(linkCity).Build().Perform();
            Thread.Sleep(1000);
            linkCity.Click();
            Thread.Sleep(2000);
        }

    }
}
