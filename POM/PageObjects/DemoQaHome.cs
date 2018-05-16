using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects
{
    class DemoQaHome
    {
        IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement pageHeading;

        public DemoQaHome(IWebDriver dr)
        {
            driver = dr;
            PageFactory.InitElements(driver, this);
        }
    }
}
