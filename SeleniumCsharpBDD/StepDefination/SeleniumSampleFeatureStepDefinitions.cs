using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;

[Binding]
public class SampleFeatureSteps
{
    private IWebDriver _driver;

    [Given("I open the browser")]
    public void GivenIOpenTheBrowser()
    {
        _driver = new ChromeDriver();
    }

    [When("I navigate to \"(.*)\"")]
    public void WhenINavigateTo(string url)
    {
        _driver.Navigate().GoToUrl(url);
    }

    [Then("the page should contain the text \"(.*)\"")]
    public void ThenThePageShouldContainTheText(string expectedText)
    {
        var pageSource = _driver.PageSource;
        Assert.IsTrue(pageSource.Contains(expectedText), $"Expected text '{expectedText}' not found on the page.");
    }

    [When("I enter \"(.*)\" into the search box")]
    public void WhenIEnterTextIntoTheSearchBox(string searchText)
    {
        var searchBox = _driver.FindElement(By.Name("q"));
        searchBox.SendKeys(searchText);
    }

    [When("I press the Enter key")]
    public void WhenIPressTheEnterKey()
    {
        var searchBox = _driver.FindElement(By.Name("q"));
        searchBox.SendKeys(Keys.Enter);
    }

    [Then("the search results page should be displayed")]
    public void ThenTheSearchResultsPageShouldBeDisplayed()
    {
        Assert.IsTrue(_driver.Title.Contains("Google Search"), "Search results page not displayed.");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}
