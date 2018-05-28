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
           // log.Info("Clicked on element :" + element);
        }

        public static bool IsDisplayed(this IWebElement element)
        {
            bool displayed;
            try
            {
                displayed = element.Displayed;                
            }
            catch(Exception e)
            {
                displayed = false;
            }
            test.Log(LogStatus.Info, "Element +'"+element+"' is Displayed :"+displayed);
          //  log.Info("Element +'" + element + "' is Displayed :" + displayed);
            return displayed;            
        }

        public static void SendText(this IWebElement element,string text)
        {
            element.Clear();
            element.SendKeys(text);
            test.Log(LogStatus.Info, "Text sent to :" + element);
           // log.Info("Text sent to: " + element);
        }


    }
}
