﻿using OpenQA.Selenium.Chrome;
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
    internal class Locators
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
        public void TextBox()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://demoqa.com/text-box";

            driver.FindElement(By.Id("userName")).SendKeys("Ishan");
            //driver.FindElement(By.Id("userName")).Clear();
            driver.FindElement(By.Id("userEmail")).SendKeys("ishan.n@simformsolutions.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("5th floor simform slutions");
            driver.FindElement(By.Id("submit")).Submit();

            driver.Quit();
        }
        [Test]
        public void CheckBox()
        {
            driver.Url = "https://demoqa.com/checkbox";

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")));

            driver.FindElement(By.XPath("//div[@id='tree-node']//span//span[1]//*[name()='svg']")).Click();
            //To get text contex
            String message =  driver.FindElement(By.ClassName("display-result")).Text;
            TestContext.Progress.WriteLine(message);
            driver.Quit();
        }
        [Test]
         public void LinkText()
        {
          
            driver.Url = "https://demoqa.com/links";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Home")));


            //TO store the webelement data in varriable
            IWebElement lintext =   driver.FindElement(By.LinkText("Home"));
            lintext.Click();
           String hrefatrb =  lintext.GetAttribute("href");

            // Assertion
          //  Assert.AreEqual(hrefatrb, hrefatrb);
            driver.Quit();
        }
        [Test]
        public void RadioButton()
        {
            driver.Url = "https://demoqa.com/radio-button";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//label[@class='custom-control-label']")));

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(By.XPath("//label[@class='custom-control-label']")).Click();

            driver.Quit();

        }



        [Test]
        public void AutoSuggestiveDropdown()
        {
           
            driver.Url = "https://demoqa.com/automation-practice-form";
        
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(600));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@id ='subjectsInput']")));

            //scroll
            IWebElement scroll = driver.FindElement(By.XPath("//input[@id ='subjectsInput']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", scroll);

            driver.FindElement(By.XPath("//input[@id ='subjectsInput']")).SendKeys("Maths");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//div[text()='Maths']")).Click();
            driver.Quit(); // 1 window close single window
        }

    }
}
