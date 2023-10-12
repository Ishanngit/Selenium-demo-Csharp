using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    internal class FormAssertion
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
        public void FromTest()
        {
            driver.Url = "https://demoqa.com/automation-practice-form";
            
            driver.FindElement(By.Id("firstName")).SendKeys("Ishan");
            driver.FindElement(By.Id("lastName")).SendKeys("Nayak");
            driver.FindElement(By.Id("userEmail")).SendKeys("ishan.n@simformsolutions.com");
            IWebElement radio =  driver.FindElement(By.XPath("//input[@id='gender-radio-1']"));
            radio.Click();
                        
            // driver.Close(); // 1 window close single window
        }
    }
}
