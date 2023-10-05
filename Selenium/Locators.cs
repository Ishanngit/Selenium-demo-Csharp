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
          //  new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
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
            //To get text contex
            String message =  driver.FindElement(By.ClassName("display-result")).Text;
            TestContext.Progress.WriteLine(message);
            //driver.Close(); // 1 window close single window
        }
        [Test]
            public void LinkText()
        {
            driver.Url = "https://demoqa.com/links";
            //TO store the webelement data in varriable
          IWebElement lintext =   driver.FindElement(By.LinkText("Home"));
            // lintext.Click();
           String hrefatrb =  lintext.GetAttribute("href");

            // Assertion
            Assert.AreEqual(hrefatrb, hrefatrb);
            driver.Close();
        }
        [Test]
        public void RadioButton()
        {
            driver.Url = "https://demoqa.com/radio-button";

            driver.FindElement(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")).Click();

            //driver.Close(); // 1 window close single window
        }

        [Test]
            public void StaticDropdown()
        {
            driver.Url = "https://demoqa.com/automation-practice-form";

            driver.FindElement(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")).Click();

            //driver.Close(); // 1 window close single window
        }

    }
}
