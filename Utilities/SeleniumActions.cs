using AutomationFramework.SupportLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    class SeleniumActions:DriverClass
    {
        /// <summary>
        /// Provide link text to click on it 
        /// </summary>
        /// <param name="linkText"></param>
        public void ClickOnLink(string linkText)
        {
            dr.FindElement(By.LinkText(linkText)).Click();
        }

        /// <summary>
        /// This method will move the given web element to the given offset
        /// </summary>
        /// <param name="element"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        public void MoveElementBy(IWebElement element, int xoffset, int yoffset)
        {
            Actions act = new Actions(dr);
            act.DragAndDropToOffset(element, xoffset, yoffset).Build().Perform();
        }

    }
}
