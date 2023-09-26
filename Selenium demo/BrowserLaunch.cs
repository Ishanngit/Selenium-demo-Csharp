using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Net.Configuration;
using System.Runtime.ConstrainedExecution;

namespace BrowserLaunch
{
    [TestClass]
    class class1
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.google.com");
        }
    }

}
