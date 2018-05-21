using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.PageObjects.Draggable;
using AutomationFramework.POM.TestCases.TestSetup;
using AutomationFramework.SupportLibrary;
using AutomationFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.TestCases
{
    class ConstrainMovementDrag:TestBase
    {
       [Test]
       public void ValidateContrainMovementDrag()
        {
            DemoQaHome hm = new DemoQaHome(dr);
            hm.ClickOnMenuItem("Draggable");
            ExplicitWaits.ElementIsVisible(By.TagName("h1"));
            Assert.AreEqual("Draggable", dr.FindElement(By.TagName("h1")).Text);
            DefaultDraggable drg = new DefaultDraggable(dr);
            SeleniumScreenshot.TakeScreenShot("DraggableHome.png");
            drg.ClickOnLink("Constrain movement");

        }
    }
}
