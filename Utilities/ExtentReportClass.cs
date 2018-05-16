using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.SupportLibrary
{
    public class ExtentReportClass:DriverClass
    {
        //Instance of extents reports

        public static ExtentReports extent;

        public static ExtentTest test;

        /// <summary>
        ///Create Extent report Instacne 
        /// </summary>        
        public static void CreateExtentReportInstacne()
        {
            extent = new ExtentReports(ProjectPath.getProjectPath() + @"\Reports\Reports.html", true, DisplayOrder.NewestFirst);
        }
        
        /// <summary>
        /// starting Extent Test
        /// </summary>
        public static void StartExtentTest()
        {
            string currentTestClass = TestContext.CurrentContext.Test.ClassName;
            test = extent.StartTest(currentTestClass);
        }
        //Closing test
        public static void EndExtentTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
                test.Log(LogStatus.Fail, status + errorMessage);
            //End test report
            extent.EndTest(test);
        }
        //Flusing Extent report
        public static void FlushExtentReport()
        {
            extent.Flush();
        }
    }
}
