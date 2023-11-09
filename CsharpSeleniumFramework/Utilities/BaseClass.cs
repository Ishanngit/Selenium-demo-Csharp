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
using CsharpSeleniumFramework.TestData;
using System.Threading;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using ICSharpCode.SharpZipLib.Zip;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.DevTools.V116.Page;
using OpenQA.Selenium.Support.UI;
using CsharpSeleniumFramework.PageObject;
using Serilog;

namespace CsharpSeleniumFramework.Utilities
{
    public class BaseClass
    {
        String browserName;
        ExtentReport ExtentReport;
        protected WaitsLogic WaitsLogic;
        [SetUp]
        public void Setup()
        {
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

           
        }
        public BaseClass()
        {
            WaitsLogic = new WaitsLogic(); // Initialize the WaitsLogic object
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentReport = new ExtentReport();
            ExtentReport.Setup();
        }
        public static IWebDriver driver;
        private static WebDriverWait wait;
        public void Waitpage()
        {
           
            WaitsLogic = new WaitsLogic();
        }


        //  public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        [SetUp]

        public void StartBrowser()
        {
          
            //configuration
            browserName = TestContext.Parameters["browserName"];
            if(browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["Browser"];

            }
            InitBrowser(browserName);
            driver.Manage().Window.Maximize();

        }
       /* public IWebDriver getDriver()
        {
            return driver.Value;
        }*/

        public void InitBrowser(string browserName)
        {   
                    driver = browserName.ToLower() switch
                    {
                        "chrome" => new ChromeDriver(),
                        "firefox" => new FirefoxDriver(),
                        "edge" => new EdgeDriver(),
                        _ => new ChromeDriver() // Use Chrome as the default browser
                            };
         
            
          
        }
        
        [TearDown]
        public void AfterTest()

        {
          
            ExtentReport.Teardown();
            Log.Information("Test completed successfully1.");
            Log.Debug("Log");
            Log.Error("Error log");

            driver.Quit();

          
        }
        

    }
}
