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

        //interactions menu
        public Dictionary<string, IWebElement> MenuInteractionsItems()
        {
            var itemList = driver.FindElement(By.Id("menu-interactions")).FindElements(By.TagName("a"));
            Dictionary<string,IWebElement> list = new Dictionary<string, IWebElement>();
            foreach (var i in itemList)
                list.Add(i.Text, i);
            return list;
        }
    }
}
