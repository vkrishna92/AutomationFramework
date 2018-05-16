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
    
    class TestBase:ExtentReportClass
    {
        //protected IWebDriver dr;
       
        [SetUp]
        public void setup()
        {
            string currentTestClass = TestContext.CurrentContext.Test.ClassName;
            //string[] str = currentTestClass.Split('.');
            //test = extent.StartTest(str[5].Substring(1)); //”SampleReporting” TestMethod name      
            test = extent.StartTest(currentTestClass);
            //Open Browser
            dr = BrowserFactory.getBrowser(dr);
            //Login to stating portal
            TestInit.uManageLogin(dr);
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("entry-title")));
        }
        [TearDown]
        public void closure()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
                    test.Log(LogStatus.Fail, status + errorMessage);            
            //End test report
            extent.EndTest(test);
            dr.Close();            
        }

    }
}
