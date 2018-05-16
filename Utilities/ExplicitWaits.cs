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
        private static WebDriverWait wait = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
        public static void AlertIsPresent()
        {
            wait.Until(ExpectedConditions.AlertIsPresent());            
        }
        public static void ElementExists(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementExists(elementBy_Object));
            
        }
        public static void ElementIsVisible(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(elementBy_Object));
        }
        public static void ElementToBeClickable(By elementBy_Object)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(elementBy_Object));
        }
        public static void ElementToBeClickable(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));            
        }        

    }
}
