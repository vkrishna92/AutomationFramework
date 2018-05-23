using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects
{
    class InteractionsMenu:DriverClass
    {
        public IWebElement Draggable = dr.FindElement(By.LinkText("Draggable"));
        public IWebElement Droppable = dr.FindElement(By.LinkText("Droppable"));
        public IWebElement Resizable = dr.FindElement(By.LinkText("Resizable"));
        public IWebElement Selectable = dr.FindElement(By.LinkText("Selectable"));
        public IWebElement Sortable = dr.FindElement(By.LinkText("Sortable"));
    }
}
