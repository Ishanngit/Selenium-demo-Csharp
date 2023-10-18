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
    public class LoginPage 
    { 
        private IWebDriver driver;

       
        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        
        }

        //pageobject factory
        //variable should be declare as private 
       
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;


        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;


        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement submit;

        //method should be public


        public void validlogin(string useranamedata , string passworddata)
        {
            username.SendKeys(useranamedata);
            password.SendKeys(passworddata);
            submit.Click();

        }
        public IWebElement GetUserName()
        {
            return username;
        }
        public IWebElement GetPassword()
        {
            return password;
        }
        public IWebElement Login()
        {
            return submit;
        }

      
    }
}
