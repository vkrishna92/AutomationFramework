using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.TestCases.TestSetup;
using AutomationFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.TestCases
{
    class DempHomeTitle:TestBase
    {
        [Test]
        public void TC102_TitleValidation()
        {
            DemoQaHome dm = new DemoQaHome(dr);
            SeleniumScreenshot.TakeFullPageScreenShot("DemoHome");
            //Validate Page title 
            Assert.AreEqual("Home", dm.pageHeading.Text);
            test.Log(LogStatus.Pass, "Page heading validated");

        }
    }
}
