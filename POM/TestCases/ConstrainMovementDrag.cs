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
            //Click on Draggable side Menu
            hm.ClickOnMenuItem("Draggable");
            ExplicitWaits.ElementIsVisible(By.TagName("h1"));//Wait for the heading to display
            Assert.AreEqual("Draggable", dr.FindElement(By.TagName("h1")).Text);//Asserting headings
            //Creating object for the page
            DefaultDraggable drg = new DefaultDraggable(dr);
            SeleniumScreenshot.TakeScreenShot("DraggableHome.png");//Take initial screenshot of Draggable home page
            //Click on Constrain Movement side menu
            drg.ClickOnLink("Constrain movement");
            DraggableContraintMovement cons = new DraggableContraintMovement(dr);
            SeleniumScreenshot.TakeScreenShot("ContrainMovement.png");
            cons.MoveElementBy(cons.horizontalDrag, 100, 0);
            cons.MoveElementBy(cons.verticalDrag, 0, 50);
            cons.MoveElementBy(cons.constrainDrag, 100, 100);
            SeleniumScreenshot.TakeScreenShot("AfterContrainMovement", cons.constrainDrag);

        }
    }
}
