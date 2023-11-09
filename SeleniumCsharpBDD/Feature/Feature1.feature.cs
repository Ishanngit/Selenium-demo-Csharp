using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;

[Binding]
public class BrowserLaunchSteps
{
    private IWebDriver _driver;

    [Given("I launch the Chrome browser")]
    public void GivenILaunchTheChromeBrowser()
    {
        _driver = new ChromeDriver();
    }

    [Then("the browser should be open")]
    public void ThenTheBrowserShouldBeOpen()
    {
        // Add an assertion to check if the browser is open
        Assert.IsNotNull(_driver);

        // Close the browser
        _driver.Quit();
    }
}
