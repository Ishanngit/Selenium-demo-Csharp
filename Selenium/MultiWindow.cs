using System;
using NUnit.Framework;
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MultiWindow
{
    class MultiWindow
    {
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
          
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void test_window_ops()
        {
            String test_url_1 = "https://www.lambdatest.com";
            String test_url_2 = "https://www.lambdatest.com/blog/";
            String test_url_2_title = "LambdaTest Blogs | A Cross Browser Testing Blog";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Url = test_url_1;

            
            System.Threading.Thread.Sleep(4000);

    
            js.ExecuteScript("window.open('" + test_url_2 + "', '_blank', 'toolbar=yes,scrollbars=yes,resizable=yes,width=800,height=800')");

            System.Threading.Thread.Sleep(6000);
            Assert.AreEqual(2, driver.WindowHandles.Count);

            var newWindowHandle = driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));

            
            string expectedNewWindowTitle = test_url_2_title;
            Assert.AreEqual(driver.SwitchTo().Window(newWindowHandle).Title, expectedNewWindowTitle);

        
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            System.Threading.Thread.Sleep(2000);

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}