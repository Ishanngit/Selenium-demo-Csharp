using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    public class SeleniumFirstTest
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
           new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
           driver = new ChromeDriver();
           driver.Manage().Window.Maximize();

        }
        [Test]
        public void Test1()
        {
            driver.Url = "https://demoqa.com/automation-practice-form";
            //driver.Title;
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);

           // driver.Quit(); // 2 window close (multiple window)
            driver.Close(); // 1 window close single window
        }
      
    }
}
