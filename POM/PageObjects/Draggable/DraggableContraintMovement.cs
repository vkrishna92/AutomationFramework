using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.Draggable
{
    class DraggableContraintMovement:SeleniumActions
    {
        IWebDriver driver;
        [FindsBy(How = How.Id, Using = "draggabl")]
        public IWebElement verticalDrag;

        [FindsBy(How = How.Id, Using = "draggabl2")]
        public IWebElement horizontalDrag;

        [FindsBy(How = How.Id, Using = "draggabl3")]
        public IWebElement constrainDrag;
        
        public DraggableContraintMovement(IWebDriver dr)
        {
            driver = dr;
            PageFactory.InitElements(dr, this);
        }

        [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement pageHeading;
        

    }
}
