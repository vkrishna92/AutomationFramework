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
    class DraggableSubMenu:DriverClass
    {
        [FindsBy(How = How.LinkText, Using = "Constrain movement")]
        public IWebElement ConstrainMovement;
        [FindsBy(How = How.LinkText, Using = "Cursor style")]
        public IWebElement CursorStyle;
        [FindsBy(How = How.LinkText, Using = "Events")]
        public IWebElement Events;
        [FindsBy(How = How.LinkText, Using = "Draggable + Sortable")]
        public IWebElement draggableSortable;

        public DraggableSubMenu(IWebDriver driver)
        {
            dr = driver;
            PageFactory.InitElements(dr, this);
        }
    }
}
