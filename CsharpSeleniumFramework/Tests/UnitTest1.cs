using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using CsharpSeleniumFramework.Utilities;
using CsharpSeleniumFramework.PageObject;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualBasic;


namespace CsharpSeleniumFramework.Tests
{
    internal class AddCart : BaseClass
    {
       
              [Test, TestCaseSource("AddTestDataConfig")]

       

        //[TestCase("student", "Password123")]
        // [TestCase("student1", "Password123")]

        //run all data sets parellel

         [Parallelizable(ParallelScope.All)]
        //run all tests method in one class parellel

        //[Parallelizable(ParallelScope.Children)]
        //run all tests files in project parellel
      //  [Parallelizable(ParallelScope.Self)]

        public void Login(string username , string password)
        {
            // Navigate to browser
            driver.Value.Url = "https://practicetestautomation.com/practice-test-login/";

            
            //Wait untill page load

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("username")));

            

            LoginPage loginPage = new LoginPage(getDriver());
            loginPage.validlogin(username, password);


        }

        [Test]
            public void Cart()
        {
            // Navigate to browser
            driver.Value.Url = "https://practice.automationtesting.in/";

            string[] ExpectedProducts = { "HTML5 Forms,Android Quick Start Guide" };
            //Wait untill page load

            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='cartcontents']")));

            // IList<IWebElement> products =  driver.FindElements(By.TagName("h3"));
            IWebElement products = driver.Value.FindElement(By.TagName("h3"));
            
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
            //scroll
            
            IWebElement scroll = driver.Value.FindElement(By.XPath("//a[@href='/?add-to-cart=160'][@rel='nofollow']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver.Value;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", scroll);

            driver.Value.FindElement(By.XPath("//a[@href='/?add-to-cart=160'][@rel='nofollow']")).Click();
            driver.Value.FindElement(By.XPath("//span[@class='cartcontents']")).Click();
            driver.Value.Navigate().Refresh();


            //cart verificaion

            driver.Value.FindElement(By.XPath("//span[@class='cartcontents']")).Click();
            //driver.Navigate().Refresh();
            IWebElement cartproduct = driver.Value.FindElement(By.XPath("//td[@class='product-name']"));
            driver.Value.Navigate().Refresh();
            driver.Value.FindElement(By.XPath("//a[contains(@class,'checkout-button')]")).Click();
             //Thread.Sleep(1000);

            


        }
        public static IEnumerable<TestCaseData> AddTestDataConfig()
        {
            //yield return new TestCaseData("student", "Password123");
           
           yield return new TestCaseData(getDataParser().extractData("username"), getDataParser().extractData("password"));
           yield return new TestCaseData("student11", "Passworda12a3");

        }
    }
}
