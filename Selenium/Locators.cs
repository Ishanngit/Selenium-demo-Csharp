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
    internal class Locators
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
        public void TextBox()
        {
            driver.Url = "https://demoqa.com/text-box";

            driver.FindElement(By.Id("userName")).SendKeys("Ishan");
            //driver.FindElement(By.Id("userName")).Clear();
            driver.FindElement(By.Id("userEmail")).SendKeys("ishan.n@simformsolutions.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("5th floor simform slutions");
            driver.FindElement(By.Id("submit")).Submit();

              driver.Close(); // 1 window close single window
        }
        [Test]
        public void CheckBox()
        {
            driver.Url = "https://demoqa.com/checkbox";

            driver.FindElement(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")).Click();

            //driver.Close(); // 1 window close single window
        }
        [Test]
        public void RadioButton()
        {
            driver.Url = "https://demoqa.com/radio-button";

            driver.FindElement(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")).Click();

            //driver.Close(); // 1 window close single window
        }
    }
}
