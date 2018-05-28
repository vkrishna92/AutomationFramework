using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.SupportLibrary
{
    class BrowserFactory
    {
        //Methods take driver and Browser name and retuns browser driver 
        public static IWebDriver getBrowser(IWebDriver dr,string browser="chrome")
        {
            // feel free to add more drivers
            if (browser.ToLower() == "firefox")
            {
                dr = new FirefoxDriver();
            }
            else if (browser.ToLower() == "htmlunit")
            {
                dr = new RemoteWebDriver(DesiredCapabilities.HtmlUnit());
            }
            else if(browser.ToLower()=="edge")
            {
                InternetExplorerOptions caps = new InternetExplorerOptions{ IgnoreZoomLevel = true };                
                //caps.SetCapability("ignoreZoomSetting", true);
                dr = new InternetExplorerDriver(caps);
               // dr = new InternetExplorerDriver();
            }
            else
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                //chromeOptions.AddArguments("--start-maximized");
                //dr = new ChromeDriver(options);
                dr = new ChromeDriver();
            }
            dr.Manage().Window.Maximize();
            return dr;
        }
    }
}
