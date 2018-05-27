using AutomationFramework.SupportLibrary;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities
{
    class SeleniumScreenshot : DriverClass
    {
        private static string folder_Path;
        static ITakesScreenshot scrnDriver;
        private static ExtentTest test;
        static SeleniumScreenshot()
        {
            scrnDriver = (ITakesScreenshot)dr;
            test = ExtentReportClass.test;
        }
        

        /// <summary>
        /// Takes screenshot without scrolling in Png format
        /// </summary>
        public static void TakeScreenShot(string fileName)
        {
            
            Screenshot scrnsht = scrnDriver.GetScreenshot();
            scrnsht.SaveAsFile(folder_Path+"\\"+fileName, ScreenshotImageFormat.Jpeg);
            test.Log(LogStatus.Info,"Screenshot :"+test.AddScreenCapture(folder_Path + "\\" + fileName));

        }

        /// <summary>
        /// Provide folder name to create a folder to store screenshots.
        /// </summary>
        /// <param name="folderName"></param>
        public static void CreateDirectoryForScreenshots(string folderName)
        {            
            //GetProjectPath--> Initial Path , TestContext 
            string folderPath = ProjectPath.getProjectPath() + "\\Screenshots";
            Directory.CreateDirectory(folderPath+"\\"+folderName);
            folder_Path = folderPath + "\\" + folderName;
        }

        private static void ScrollToElement(IWebElement webElement)
        {
            Actions act = new Actions(dr);
            act.MoveToElement(webElement).Build().Perform();
        }

        private static void scrollToLocation(int xloc,int yloc)
        {

            ((IJavaScriptExecutor)dr).ExecuteScript("window.scrollBy(0," + yloc + ");");
        }

        /// <summary>
        /// Takes full page  screenshot
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="webElement"></param>
        public static void TakeFullPageScreenShot(string fileName)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)dr;
            //int height = Convert.ToInt32((js.ExecuteScript("return window.innerHeight")));
            int height = Convert.ToInt32((js.ExecuteScript("return document.documentElement.scrollHeight")));
            //document.body.scrollHeight
            int xLoc = 0;int yLoc = 0;
            while(yLoc<=height)
            {
                scrollToLocation(0, yLoc);
                TakeScreenShot(fileName+"_"+yLoc+".png");
                yLoc = yLoc + 100;                  
            }
        }

        
    }
}
