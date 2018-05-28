using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.SupportLibrary;
using AutomationFramework.Utilities;
using System.Threading;

namespace AutomationFramework.POM.TestCases.TestSetup
{
    
    class TestBase:DriverClass
    {
        public ExtentTest test;
        [SetUp]
        public void setup()
        {
            var directoryName = TestContext.CurrentContext.Test.Name.ToString();            
            //Open Browser
            dr = BrowserFactory.getBrowser(dr);
            //start Extent Test            
            ExtentReportClass.StartExtentTest();
            test = ExtentReportClass.test;
            //Create folder for screenshots
            SeleniumScreenshot.CreateDirectoryForScreenshots(directoryName);
            //Login to stating portal
            TestInit.ManageLogin(dr);
            //Explicit wait   
            Thread.Sleep(1000);
            ExplicitWaits.ElementExists(By.ClassName("entry-title"));
        }
        
        [TearDown]
        public void closure()
        {
            //StackTrace details for failed Testcases
            ExtentReportClass.EndExtentTest();
            dr.Close();
            dr.Quit();
            dr.Dispose();
            Thread.Sleep(2000);
        }

    }
}
