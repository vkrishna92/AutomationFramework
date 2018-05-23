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
        public IWebElement MenuItem_Home = dr.FindElement(By.LinkText("Home"));        
        public IWebElement MenuItem_AboutUS = dr.FindElement(By.LinkText("About us"));       
        public IWebElement MenuItem_Services = dr.FindElement(By.LinkText("Services"));        
        public IWebElement MenuItem_Blog = dr.FindElement(By.LinkText("Blog"));        
        public IWebElement MenuItem_Contact = dr.FindElement(By.LinkText("Contact"));
    }
}
