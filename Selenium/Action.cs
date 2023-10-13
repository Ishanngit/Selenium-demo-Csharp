using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    internal class Action
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
        public void Actiontest()
        {
      
            driver.Url = "https://www.rahulshettyacademy.com/";
            //actions class example
           Actions a = new Actions(driver);
            // move to element comes from actions class

           a.MoveToElement(driver.FindElement(By.CssSelector("a.dropdown-toggle"))).Perform();
            //driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a")).Click();
            a.MoveToElement(driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a"))).Click().Perform();
            driver.Quit();
        }
        [Test]
        public void DragAndDrop()
        {
            
            driver.Url = "https://demoqa.com/droppable";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Actions a = new Actions(driver);
            a.DragAndDrop(driver.FindElement(By.Id("draggable")),(driver.FindElement(By.Id("droppable")))).Perform();
            driver.Quit();
        }

        [Test]
        public void ChildWindow()
        {

            driver.Url = "https://demo.automationtesting.in/Windows.html";

            driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Click();
            Assert.AreEqual(2,driver.WindowHandles.Count);
            //changing window
            String childwindow = driver.WindowHandles[1];
            driver.SwitchTo().Window(childwindow);

            String message = driver.FindElement(By.XPath("//h1[@class='d-1 fw-bold']")).Text;
            TestContext.Progress.WriteLine(message);
            driver.Quit();
        }
        [Test]
        public void StringSplit()
        {

            driver.Url = "https://demo.automationtesting.in/Windows.html";

            driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Click();
            String parentwindowhandle = driver.CurrentWindowHandle;

            //changing window
            String childwindow = driver.WindowHandles[1];
            driver.SwitchTo().Window(childwindow);

            String message = driver.FindElement(By.XPath("//h1[@class='d-1 fw-bold']")).Text;
            TestContext.Progress.WriteLine(message);
            //Spliting the text "Selenium automates browsers. That's it!"

            String[] splittedText =  message.Split("automates");

           // splittedText[1]

            String[] trimmedString =  splittedText[1].Trim().Split(" ");
            //switch back to parent window
            driver.SwitchTo().Window(parentwindowhandle);
           String message1=  driver.FindElement(By.XPath("//div[@class='col-sm-8 col-xs-8 col-md-8']")).Text;
            TestContext.Progress.WriteLine(message1);
            driver.Quit();
        }

    }
}
