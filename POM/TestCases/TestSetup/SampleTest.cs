using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFramework.POM.PageObjects;
using AutomationFramework.SupportLibrary;
using AutomationFramework.TestData.TestDataClass;

namespace AutomationFramework.POM.TestCases.TestSetup
{
   
    class SampleTest
    {
        //IWebDriver dr;
        //[SetUp]
        //public void setup()
        //{
        //    dr = BrowserFactory.getBrowser(dr);

        //    //Login to stating portal
        //    TestInit.uManageLogin(dr);
        //}
        [Test]
        public void testCase()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Url = "qa.utelogy.com";
            
        }

        //[TearDown]
        //public void teardown()
        //{
        //    dr.Quit();
        //}
        

    }
}
