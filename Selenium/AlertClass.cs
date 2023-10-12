using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;



namespace Selenium
{
    internal class AlertCLass
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //      new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Alert()
        {
            String name = "You clicked a button";


           
            driver.Url = "https://demoqa.com/alerts";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            String alerttext = driver.SwitchTo().Alert().Text;

            //Assertion

            StringAssert.Contains(name, alerttext);
            driver.SwitchTo().Alert().Accept();
            driver.Close(); // 1 window close single window
        }

        [Test]
        public void AlertDismiss()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://demoqa.com/alerts";


            driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            String alerttext = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Dismiss();
            driver.Close();
        }

        [Test]
        public void AlertTextSend()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://demoqa.com/alerts";


            driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            driver.SwitchTo().Alert().SendKeys("This is ishan");
            driver.SwitchTo().Alert().Accept();
            driver.Close();
        }

    }
}
