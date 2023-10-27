using CsharpSeleniumFramework.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSeleniumFramework.PageObject
{
    public class WaitsLogic
    {
        public IWebElement WaitForElementToBeVisible(By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(BaseClass.driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public bool WaitForElementToBeClickable(By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(BaseClass.driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator)) != null;
        }
    }
}

