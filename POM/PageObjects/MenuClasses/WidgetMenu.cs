using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.MenuClasses
{
    class WidgetMenu:DriverClass
    {
        [FindsBy(How = How.LinkText, Using = "Accordion")]
        public IWebElement Accordion;
        [FindsBy(How = How.LinkText, Using = "Autocomplete")]
        public IWebElement Autocomplete;
        [FindsBy(How = How.LinkText, Using = "Datepicker")]
        public IWebElement Datepicker;
        [FindsBy(How = How.LinkText, Using = "Menu")]
        public IWebElement Menu;
        [FindsBy(How = How.LinkText, Using = "Slider")]
        public IWebElement Slider;
        [FindsBy(How = How.LinkText, Using = "Tabs")]
        public IWebElement Tabs;
        [FindsBy(How = How.LinkText, Using = "Tooltip")]
        public IWebElement Tooltip;

        public WidgetMenu(IWebDriver driver)
        {
            dr = driver;
            PageFactory.InitElements(dr, this);
        }
    }
}
