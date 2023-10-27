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
using static System.Net.WebRequestMethods;

namespace Selenium
{
    internal class XpathAxes
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Actiontest()
        {
            string url = "https://demoqa.com/";
            driver.Navigate().GoToUrl(url);

            try
            {
                
                string sampleHtml = @"
                <div class='container'>
                    <div class='parent' id='parent'>
                        <div class='child'>Child 1</div>
                        <div class='child'>Child 2</div>
                        <div class='child'>Child 3</div>
                    </div>
                </div>";
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("document.body.innerHTML = arguments[0]", sampleHtml);

                // Select and interact with elements using XPath axes
                IWebElement parentElement = driver.FindElement(By.Id("parent"));

                // Using the Child Axis
                IWebElement firstChild = parentElement.FindElement(By.XPath(".//div[@class='child'][1]"));
                Console.WriteLine("First Child Text: " + firstChild.Text);

                // Using the Ancestor Axis
                IWebElement ancestorElement = firstChild.FindElement(By.XPath("./ancestor::div"));
                Console.WriteLine("Ancestor Element Text: " + ancestorElement.Text);

                // Using the Following Axis
                IWebElement followingElement = firstChild.FindElement(By.XPath("./following-sibling::div"));
                Console.WriteLine("Following Sibling Text: " + followingElement.Text);
            }
            finally
            {
                // Close the WebDriver
                driver.Quit();
            }
        }
        [Test]
        public void Child()
        {
            driver.Url = "https://www.tools4testing.com/contents/selenium/testpages/xpath-axes-testpage";

            driver.FindElement(By.XPath("//form[@id='form']/child::input[9]")).SendKeys("Test");

            driver.Quit();
        }
        [Test]
        public void descendant()
        {
            driver.Url = "https://www.tools4testing.com/contents/selenium/testpages/xpath-axes-testpage";

            driver.FindElement(By.XPath("//descendant::input[5]")).SendKeys("Test");
            driver.Quit();

        }
        [Test]
        public void precedingsibling()
        {
            driver.Url = "https://www.tools4testing.com/contents/selenium/testpages/xpath-axes-testpage";

            driver.FindElement(By.XPath("//input[5]/preceding-sibling::input")).SendKeys("Test");
            driver.Quit();

        }
        [Test]
        public void follwoingsibling()
        {
            driver.Url = "https://www.tools4testing.com/contents/selenium/testpages/xpath-axes-testpage";

            driver.FindElement(By.XPath("//input[5]/following-sibling::input")).SendKeys("Test");
            driver.Quit();

        }
        [Test]
       public void parent()
        {
            driver.Url = "https://www.tools4testing.com/contents/selenium/testpages/xpath-axes-testpage";

            driver.FindElement(By.XPath("//descendant::input[5]/parent::form"));
            driver.Quit();

        }
    }
    }
