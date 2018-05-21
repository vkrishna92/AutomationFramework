using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    class SeleniumActions:DriverClass
    {
        public void ClickOnLink(string linkText)
        {
            dr.FindElement(By.LinkText(linkText)).Click();
        }
    }
}
