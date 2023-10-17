using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Configuration;

namespace CsharpSeleniumFramework.Utilities
{
    internal class BaseClass
    {
        public IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //configuration
            String browserName = ConfigurationManager.AppSettings["Browser"];
            InitBrowser(browserName);
            driver.Manage().Window.Maximize();

        }
        public void InitBrowser(string browserName)
        {   
            switch(browserName)
            {
                case "Firefox":
                        driver = new FirefoxDriver();
                        break;

                case "Chrome":
                        driver = new ChromeDriver();
                        break;
                        
                case "Edge":
                        driver = new EdgeDriver();
                        break;
            }
                

        }
        [TearDown]
        
        public void StopBrowser()
        {
            driver.Close();
        }
    }
}
