using AutomationFramework.SupportLibrary;
using NUnit.Framework;
using OpenQA.Selenium;
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
        static SeleniumScreenshot()
        {
            scrnDriver = (ITakesScreenshot)dr;            
        }
        

        /// <summary>
        /// Takes screenshot without scrolling in Png format
        /// </summary>
        public static void TakeScreenShot(string fileName)
        {
            
            Screenshot scrnsht = scrnDriver.GetScreenshot();
            scrnsht.SaveAsFile(folder_Path+"\\"+fileName, ScreenshotImageFormat.Jpeg);
        }

        /// <summary>
        /// Provide folder name to create a folder to store screenshots.
        /// </summary>
        /// <param name="folderName"></param>
        public static void CreateDirectoryForScreenshots(string folderName)
        {
            //

            //GetProjectPath--> Initial Path , TestContext 
            string folderPath = ProjectPath.getProjectPath() + "\\Screenshots";
            Directory.CreateDirectory(folderPath+"\\"+folderName);
            folder_Path = folderPath + "\\" + folderName;
        }




    }
}
