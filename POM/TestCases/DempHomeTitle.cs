using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.TestCases.TestSetup;
using AutomationFramework.Utilities;
using NUnit.Framework;
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
        public void TitleValidation()
        {
            DemoQaHome dm = new DemoQaHome(dr);
            SeleniumScreenshot.TakeScreenShot("DemoHome.jpg");
            Console.WriteLine(dm.pageHeading.Text);

        }
    }
}
