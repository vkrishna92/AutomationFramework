﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFramework.POM.PageObjects;

namespace AutomationFramework.SupportLibrary
{
    class TestInit
    {
        public static void uManageLogin(IWebDriver dr)
        {
           
            dr.Url = "http://demoqa.com/";
          
          
            Thread.Sleep(2000);
        }
        
    }
}