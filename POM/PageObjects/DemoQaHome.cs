using AutomationFramework.POM.PageObjects.MenuClasses;
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
        public MenuItems menuItem;
       [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement pageHeading;
       
        public DemoQaHome(IWebDriver dr)
        {
            driver = dr;
            menuItem = new MenuItems();

            PageFactory.InitElements(driver, this);
        }
        
        /// <summary>
        /// Return list of Menu items in Interactions side Menu
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, IWebElement> MenuInteractionsItems()
        {
            var itemList = driver.FindElement(By.Id("menu-interactions")).FindElements(By.TagName("a"));
            Dictionary<string,IWebElement> list = new Dictionary<string, IWebElement>();
            foreach (var i in itemList)
                list.Add(i.Text.ToLower(), i);
            return list;
        }

        /// <summary>
        /// Clicks on any side menu Item on Home page
        /// </summary>
        public void ClickOnMenuItem(string menuItem)
        {
            driver.FindElement(By.LinkText(menuItem)).Click();
        }
    }
}
