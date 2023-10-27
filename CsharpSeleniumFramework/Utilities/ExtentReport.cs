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

    internal class ExtentReport : BaseClass
    {
        ExtentReports extent;
        ExtentTest test;
        //Report file 
        [OneTimeSetUp]
        public void Setup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string reportPath = projectDirectory + "\\index.html";
            var htmlreporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
           
            extent.AttachReporter(htmlreporter);
            extent.AddSystemInfo("Host name", "Local Host");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Username ", "Ishan");
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        public static JsonReader getDataParser()
        {
            return new JsonReader();
        }
        [TearDown]
        public void Teardown()

        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;



            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {

             test.Fail("Test failed", captureScreenShot(driver, fileName));
                test.Log(Status.Fail, "test failed with logtrace" + stackTrace);

            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {

            }
            extent.Flush();
        }
        [OneTimeTearDown]
        public MediaEntityModelProvider captureScreenShot(IWebDriver driver, String screenShotName)

            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                var screenshot = ts.GetScreenshot().AsBase64EncodedString;

                return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();

            }
        }
    }
