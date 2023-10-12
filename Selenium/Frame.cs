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
    internal class Frame
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
        public void Frametest()
        {

            driver.Url = "https://demoqa.com/frames";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.SwitchTo().Frame("frame1");
            String message = driver.FindElement(By.Id("sampleHeading")).Text;
            TestContext.Progress.WriteLine(message);
            driver.Quit();
        }
        [Test]
        public void ScrollingPage()
        {

            driver.Url = "https://demoqa.com/frames";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

               IWebElement scroll =  driver.FindElement(By.Id("frame2"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", scroll);

            driver.Quit();
        }


    }
}
