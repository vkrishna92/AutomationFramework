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
       public void TC100_ValidateContrainMovementDrag()
        {
            DemoQaHome hm = new DemoQaHome(dr);
            //Validate home page title
            Assertions.AreEqual<String>("Home", hm.pageHeading.Text, "Validating Home page heading");          
            //Take screenshot 
            SeleniumScreenshot.TakeScreenShot("Homescreen.png");
            //Click on Draggable side Menu
            hm.menuItem.interactionMenu.Draggable.ClickOnIt();
            //Validate Draggable default page title
            DefaultDraggable  dd = new DefaultDraggable(dr);
            Assertions.AreEqual<string>("Draggable", dd.pageHeading.Text,"Validating Draggable Page heading");            
            //Take screenshot
            SeleniumScreenshot.TakeScreenShot("DraggableDefautl.png");
            //Click on constrain movement
            dd.subMenu.ConstrainMovement.ClickOnIt();
            //Take screenshot
            SeleniumScreenshot.TakeScreenShot("ConstrainMovementDefault.png");
            //Perform actions
            DraggableContraintMovement cons = new DraggableContraintMovement(dr);            
            cons.MoveElementBy(cons.horizontalDrag, 100, 0);
            cons.MoveElementBy(cons.verticalDrag, 0, 50);
            cons.MoveElementBy(cons.constrainDrag, 100, 100);
            SeleniumScreenshot.TakeScreenShot("AfterContrainMovement.png");
            test.Log(LogStatus.Pass, "Drag actions performed");
        }
    }
}
