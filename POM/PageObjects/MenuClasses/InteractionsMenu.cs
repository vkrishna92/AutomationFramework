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
    class InteractionsMenu:DriverClass
    {
        [FindsBy(How = How.LinkText, Using = "Draggable")]
        public IWebElement Draggable;

        [FindsBy(How = How.LinkText, Using = "Droppable")]
        public IWebElement Droppable;

        [FindsBy(How = How.LinkText, Using = "Resizable")]
        public IWebElement Resizable;
        [FindsBy(How = How.LinkText, Using = "Selectable")]
        public IWebElement Selectable;
        [FindsBy(How = How.LinkText, Using = "Sortable")]
        public IWebElement Sortable;

        public InteractionsMenu(IWebDriver driver)
        {
            dr = driver;
            PageFactory.InitElements(dr, this);
        }
    }
}
