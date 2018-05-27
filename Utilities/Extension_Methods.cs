using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    public static class  Extension_Methods
    {
        private static ExtentTest test = ExtentReportClass.test;
        public static void ClickOnIt(this IWebElement element)
        {
            element.Click();
            test.Log(LogStatus.Info, "Clicked on element " + element.Text);
        }
    }
}
