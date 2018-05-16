using AutomationFramework.POM.PageObjects;
using AutomationFramework.POM.TestCases.TestSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.TestCases
{
    class HomeInteractionsMenu:TestBase
    {
        [Test]
        public void ValidateHomeInteractionsMenu()
        {
            DemoQaHome hm = new DemoQaHome(dr);

            List<string> expectedItems = new List<string>()
            {
                "Draggable","Droppable","Resizable","Selectable","Sortabl"
            };
            foreach(var k in expectedItems)
            {
                if(!hm.MenuInteractionsItems().ContainsKey(k))
                {
                    Assert.Fail();
                }
            }
        }
    }
}
