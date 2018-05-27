using AutomationFramework.SupportLibrary;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    class Assertions
    {
        private static ExtentTest test = ExtentReportClass.test;
        public static void AreEqual<T>(T Expected, T Actual, string ValidationMessage)
        {
            Assert.AreEqual(Expected, Actual);
            test.Log(LogStatus.Pass, ValidationMessage);
        }
        public static void AreNotEqual<T>(T Expected,T Actual,string ValidationMessage)
        {
            Assert.AreNotEqual(Expected, Actual);
            test.Log(LogStatus.Pass, ValidationMessage);
        }
        public static void IsTrue(bool Expected,string ValidationMessage)
        {
            Assert.IsTrue(Expected);
            test.Log(LogStatus.Pass, ValidationMessage);
        }
        public static void IsFalse(bool Expected,string ValidationMessage)
        {
            Assert.IsFalse(Expected);
            test.Log(LogStatus.Pass, ValidationMessage);
        }
        public static void method1()
        {

        }
    }
}
