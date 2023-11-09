using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverManager
{
    public IWebDriver Driver { get; private set; }

    public void StartBrowser()
    {
        Driver = new ChromeDriver();
    }

    public void StopBrowser()
    {
        Driver.Quit();
        Driver.Dispose();
    }
}
