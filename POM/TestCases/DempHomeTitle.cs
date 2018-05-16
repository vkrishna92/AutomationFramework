using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.TestCases.TestSetup;
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
            Console.WriteLine(dm.pageHeading.Text);

        }
    }
}
