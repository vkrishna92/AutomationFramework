using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.PageObjects.Draggable;
using AutomationFramework.POM.TestCases.TestSetup;
using AutomationFramework.SupportLibrary;
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
    class DefaultDraggableValidation:TestBase
    {
        [Test]
        public void ValidateDefualtDraggable()
        {
            DemoQaHome hm = new DemoQaHome(dr);
            //Validate home page title 
            Assert.AreEqual("Home", hm.pageHeading.Text);
            //Take screenshot 
            SeleniumScreenshot.TakeScreenShot("Homescreen.png");
            hm.menuItem.interactionMenu.Draggable.Click();
            ExplicitWaits.ElementIsVisible(By.TagName("h1"));
            Assert.AreEqual("Draggable", dr.FindElement(By.TagName("h1")).Text);
            test.Log(LogStatus.Pass, "Draggable page title validated");
            DefaultDraggable drg = new DefaultDraggable(dr);
            SeleniumScreenshot.TakeScreenShot("DraggableHome.png");
            drg.moveElementBy(100, 100,drg.draggableBox);
            SeleniumScreenshot.TakeScreenShot("DraggableElement_afterDrag", drg.draggableBox);
            test.Log(LogStatus.Pass, "Drag operation performed");
        }
    }
}
