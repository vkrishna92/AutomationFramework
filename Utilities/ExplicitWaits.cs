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
       
    }
}
