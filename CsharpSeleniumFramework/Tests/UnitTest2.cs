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


namespace CsharpSeleniumFramework.Tests
{
    internal class UnitTest2 : BaseClass
    {
        LoginPage loginPage = new LoginPage();
        [Test, Category("Smoke")]
        
        //dotnet test projectpath.csproj  - all test
        //dotnet test projectpath.csproj  --TestCategory--Smoke --specfic

        //dotnet test CsharpSeleniumFramework.csproj --filter TestCategory=Smoke -- TestRunParameters.Parameter\(name=\"browserName\",value=\"Chrome\"\)

        public void LoginNew()
        {
            // Navigate to browser
            driver.Url = "https://practicetestautomation.com/practice-test-login/";


            /*//Wait untill page load

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("username")));
*/
            //loginPage.wait();

            loginPage.login("studentname","password");
        }




    }

}

