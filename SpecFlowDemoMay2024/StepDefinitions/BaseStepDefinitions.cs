using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoMay2024.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions
    {

       public IWebDriver dr;

        public BaseStepDefinitions()
        {
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

        }

    }
}
