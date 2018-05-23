using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.MenuClasses
{
    class DraggableSubMenu:DriverClass
    {
        public IWebElement ConstrainMovement = dr.FindElement(By.LinkText("Constrain movement"));
        public IWebElement CursorStyle = dr.FindElement(By.LinkText("Cursor style"));
        public IWebElement Events = dr.FindElement(By.LinkText("Events"));
        public IWebElement draggableSortable = dr.FindElement(By.LinkText("Draggable + Sortable"));
    }
}
