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

        //method should be public
        public IWebElement getUserName ()
        {
            return username;
        }
    }
}
