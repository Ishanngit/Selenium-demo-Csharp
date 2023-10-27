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
using CsharpSeleniumFramework.Utilities;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CsharpSeleniumFramework.PageObject
{
    public class LoginPage : BaseClass
    { 
  
        private By usernameInput = By.Id("username");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("submit");


     
        public void EnterUsername(string username)
        {
            driver.FindElement(usernameInput).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public void login(string username, string password)
        {
            WaitsLogic.WaitForElementToBeVisible(loginButton);

            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();

        }
      

    }
}
