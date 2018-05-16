using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
