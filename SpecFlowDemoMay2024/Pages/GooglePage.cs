using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemoMay2024.Pages
{
    public class GooglePage
    {
        IWebDriver dr;
        public IWebElement txtSrch => dr.FindElement(By.Name("q"));
    }
}
