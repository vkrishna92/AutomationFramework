using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects
{
    class MainMenu:DriverClass
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement MenuItem_Home;
        [FindsBy(How = How.LinkText, Using = "About us")]
        public IWebElement MenuItem_AboutUS;
        [FindsBy(How = How.LinkText, Using = "Services")]
        public IWebElement MenuItem_Services;
        [FindsBy(How = How.LinkText, Using = "Blog")]
        public IWebElement MenuItem_Blog;
        [FindsBy(How = How.LinkText, Using = "Contact")]
        public IWebElement MenuItem_Contact;

        public MainMenu(IWebDriver driver)
        {
            dr = driver;
            PageFactory.InitElements(dr, this);
        }
    }
}
