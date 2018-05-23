using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.MenuClasses
{
    class WidgetMenu:DriverClass
    {
        public IWebElement Accordion = dr.FindElement(By.LinkText("Accordion"));
        public IWebElement Autocomplete = dr.FindElement(By.LinkText("Autocomplete"));
        public IWebElement Datepicker = dr.FindElement(By.LinkText("Datepicker"));
        public IWebElement Menu = dr.FindElement(By.LinkText("Menu"));
        public IWebElement Slider = dr.FindElement(By.LinkText("Slider"));
        public IWebElement Tabs = dr.FindElement(By.LinkText("Tabs"));
        public IWebElement Tooltip = dr.FindElement(By.LinkText("Tooltip"));
    }
}
