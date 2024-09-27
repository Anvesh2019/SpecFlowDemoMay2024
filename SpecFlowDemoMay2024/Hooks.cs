using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowDemoMay2024.StepDefinitions;
using System.ComponentModel;
using BoDi;

namespace SpecFlowDemoMay2024
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver dr;
        private readonly IObjectContainer container;

   
        [BeforeScenario("@TechTutorialz")]
        public void BeforeScenarioWithTag()
        {
            //Given I navigate to "https://techtutorialz.com"
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Console.WriteLine("I am before scenario");
            //dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            //dr.Navigate().GoToUrl("https://google.com");
            //container.RegisterInstanceAs<IWebDriver>(dr);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}