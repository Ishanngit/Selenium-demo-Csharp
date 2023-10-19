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



namespace CsharpSeleniumFramework.Utilities
{
    internal class BaseClass
    {
        ExtentReports extent;
        ExtentTest test;
        String browserName;


        //Report file 
        [OneTimeSetUp]
        public void Setup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string reportPath = projectDirectory + "//index.html";
            var htmlreporter =  new ExtentHtmlReporter(reportPath);
            extent.AttachReporter(htmlreporter);
            extent.AddSystemInfo("Host name", "Local Host");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Username ", "Ishan");
        }
       // public IWebDriver driver;
        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        [SetUp]

        public void StartBrowser()
        {
           test =  extent.CreateTest(TestContext.CurrentContext.Test.Name);
            //configuration
            browserName = TestContext.Parameters["browserName"];
            if(browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["Browser"];

            }

            
            InitBrowser(browserName);
            driver.Value.Manage().Window.Maximize();

        }
        public IWebDriver getDriver()
        {
            return driver.Value;
        }

        public void InitBrowser(string browserName)
        {   
            switch(browserName)
            {
                case "  ":
                        driver.Value = new FirefoxDriver();
                        break;

                case "Chrome":
                        driver.Value = new ChromeDriver();
                        break;
                        
                case "Edge":
                        driver.Value = new EdgeDriver();
                        break;
            }
                

        }
        public static JsonReader getDataParser()
        {
            return new JsonReader();
        }
        [TearDown]
        
        public void StopBrowser()
        {
           var status =  TestContext.CurrentContext.Result.Outcome.Status;

            if(status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
              //  test.Fail("Test failed", screenshot);
            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {

            }
            driver.Value.Close();

        }

       /* public MediaEntityModelProvider captureScreenShot(IWebDriver driver, String screenShotName)

        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;

          //  return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();




        }*/
    }
}
