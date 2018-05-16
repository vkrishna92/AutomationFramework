using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.SupportLibrary
{
    class ExplicitWaits:DriverClass
    {
        WebDriverWait wait = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
        public void AlertIsPresent()
        {
            wait.Until(ExpectedConditions.AlertIsPresent());            
        }
        public void ElementExists(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementExists(elementBy_Object));
            
        }
        public void ElementIsVisible(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy_Object));
        }
        public void ElementToBeClickable(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(elementBy_Object));
        }
        public void ElementToBeClickable(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));            
        }        

    }
}
