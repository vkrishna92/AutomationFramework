using AutomationFramework.POM.PageObjects.MenuClasses;
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
    class DefaultDraggable: SeleniumActions
    {
        IWebDriver driver;
        public MenuItems menuItem;
        [FindsBy(How = How.Id, Using = "draggable")]
        public IWebElement draggableBox;

        [FindsBy(How = How.Id, Using = "tabs-1")]
        public IWebElement contrainer;

        public DefaultDraggable(IWebDriver dr)
        {
            driver = dr;
            PageFactory.InitElements(driver, this);
            menuItem = new MenuItems();
        }

        public void moveElementBy(int xoffset,int yoffset,IWebElement element)
        {
            Actions act = new Actions(driver);
            act.DragAndDropToOffset(element, xoffset, yoffset).Build().Perform();
        }
        [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement pageHeading;

    }
}
