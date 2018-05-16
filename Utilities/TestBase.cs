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

namespace AutomationFramework.POM.TestCases.TestSetup
{
    
    class TestBase:DriverClass
    {        
       
        [SetUp]
        public void setup()
        {
            //start Extent Test
            ExtentReportClass.StartExtentTest();            
            //Open Browser
            dr = BrowserFactory.getBrowser(dr);
            //Login to stating portal
            TestInit.ManageLogin(dr);
            //Explicit wait            
            ExplicitWaits.ElementExists(By.ClassName("entry-title"));
        }
        [TearDown]
        public void closure()
        {
            
            dr.Close();            
        }

    }
}
