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
    internal class AddCart
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Cart()
        {
            // Navigate to browser
            driver.Url = "https://practice.automationtesting.in/";

            String[] ExpectedProducts = { "HTML5 Forms,Android Quick Start Guide" };
            //Wait untill page load

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='cartcontents']")));

          // IList<IWebElement> products =  driver.FindElements(By.TagName("h3"));
            IWebElement products = driver.FindElement(By.TagName("h3"));

            /*foreach (IWebElement product in products)
            {
                TestContext.Progress.WriteLine(product.FindElement(By.XPath("//ul[@class='products masonry-done']")).Text);



            }*/
            if (products != null)
            {
                // Product name is present on the page
                Console.WriteLine("Product name is present: " + products.Text);
            }
            else
            {
                // Product name is not found
                Console.WriteLine("Product name is not present.");
            }

            driver.FindElement(By.XPath("//a[@href='/?add-to-cart=160'][@rel='nofollow']")).Click();
            driver.FindElement(By.XPath("//span[@class='cartcontents']")).Click();
            driver.Navigate().Refresh();


            //cart verificaion
            driver.FindElement(By.XPath("//span[@class='cartcontents']")).Click();

            IWebElement cartproduct = driver.FindElement(By.XPath("//td[@class='product-name']"));

            driver.FindElement(By.XPath("//a[contains(@class,'checkout-button')]")).Click();
            //Thread.Sleep(1000);
            driver.Close(); 
        }
    }
}
