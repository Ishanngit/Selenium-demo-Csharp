using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Docker.DotNet.Models;
using Humanizer.Localisation;

[Binding]
public class PracticeTestLoginSteps
{
    private IWebDriver _driver;
    private WebDriverWait _wait;

    [When("I wait for the element with id \"(.*)\" to be visible")]
    public void WhenIWaitForElementToBeVisible(string username)
    {
        var dynamicElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.Id(username)));
    }

    [When("I enter the username \"(.*)\"")]
    public void WhenIEnterTheUsername(string username)
    {
        
        var usernameField = _driver.FindElement(By.Id("username"));
        usernameField.SendKeys(username);
    }
    

    [When("I enter the password \"(.*)\"")]
    public void WhenIEnterThePassword(string password)
    {
        var passwordField = _driver.FindElement(By.Id("password"));
        passwordField.SendKeys(password);
    }
  
    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        var loginButton = _driver.FindElement(By.CssSelector("input[type='submit']"));
        loginButton.Click();
    }

    

}
