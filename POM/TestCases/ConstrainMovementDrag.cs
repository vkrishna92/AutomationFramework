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
    class ConstrainMovementDrag:TestBase
    {
       [Test]
       public void ValidateContrainMovementDrag()
        {
            DemoQaHome hm = new DemoQaHome(dr);
            //Validate home page title
            Assert.AreEqual("Home", hm.pageHeading.Text);           
            //Take screenshot 
            SeleniumScreenshot.TakeScreenShot("Homescreen.png");
            test.Log(LogStatus.Pass, "Home page title validated");
            //Click on Draggable side Menu
            hm.menuItem.interactionMenu.Draggable.Click();
            //Validate Draggable default page title
            DefaultDraggable  dd = new DefaultDraggable(dr);
            Assert.AreEqual("Draggable", dd.pageHeading.Text);
            test.Log(LogStatus.Pass, "Draggable page title validated");
            //Take screenshot
            SeleniumScreenshot.TakeScreenShot("DraggableDefautl.png");
            //Click on constrain movement
            dd.subMenu.ConstrainMovement.Click();
            //Take screenshot
            SeleniumScreenshot.TakeScreenShot("ConstrainMovementDefault.png");
            //Perform actions
            DraggableContraintMovement cons = new DraggableContraintMovement(dr);            
            cons.MoveElementBy(cons.horizontalDrag, 100, 0);
            cons.MoveElementBy(cons.verticalDrag, 0, 50);
            cons.MoveElementBy(cons.constrainDrag, 100, 100);
            SeleniumScreenshot.TakeScreenShot("AfterContrainMovement", cons.constrainDrag);
            test.Log(LogStatus.Pass, "Drag actions performed");
        }
    }
}
