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
            SeleniumScreenshot.TakeScreenShot("DemoHome");
            //Validate Page title             
            Assertions.AreEqual<string>("Home", dm.pageHeading.Text, "Validating Home page heading");         
        }
    }
}
