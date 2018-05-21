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
    class DraggableContraintMovement
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

        /// <summary>
        /// This method will move the given web element to the given offset
        /// </summary>
        /// <param name="element"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        public void MoveElementBy(IWebElement element,int xoffset,int yoffset)
        {
            Actions act = new Actions(driver);
            act.DragAndDropToOffset(element, xoffset, yoffset).Build().Perform();
        }

    }
}
