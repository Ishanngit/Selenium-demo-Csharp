using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    internal class AddCart
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
            public void Cart()
        {
            try
            {
                // Navigate to the practice website
                driver.Navigate().GoToUrl("https://practice.automationtesting.in/");

                // Find the "Shop" menu item and click it
                IWebElement shopMenuItem = driver.FindElement(By.LinkText("Shop"));
                shopMenuItem.Click();

                // Find the "Selenium Ruby" product and click it
                IWebElement product = driver.FindElement(By.LinkText("Selenium Ruby"));
                product.Click();

                // Find the "Add to basket" button and click it
                IWebElement addToBasketButton = driver.FindElement(By.Name("add-to-cart"));
                addToBasketButton.Click();

                // Wait for a while to ensure the cart is updated
                Thread.Sleep(2000);

                // Find the cart icon and click it
                IWebElement cartIcon = driver.FindElement(By.CssSelector(".cart-contents"));
                cartIcon.Click();

                // Find the "Proceed to Checkout" button and click it
                IWebElement proceedToCheckoutButton = driver.FindElement(By.LinkText("Proceed to Checkout"));
                proceedToCheckoutButton.Click();

                // Find the "First name" field in the billing details and enter a value
                IWebElement firstNameField = driver.FindElement(By.Id("billing_first_name"));
                firstNameField.SendKeys("John");

                // Repeat the above steps to fill in the other billing details
                // ...

                // Scroll down to find the "Place order" button
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                IWebElement placeOrderButton = driver.FindElement(By.Id("place_order"));
                js.ExecuteScript("arguments[0].scrollIntoView();", placeOrderButton);

                // Click the "Place order" button
                placeOrderButton.Click();

                // Wait for the order confirmation page to load (you may need to adapt this)
                Thread.Sleep(5000);

                // Capture the order confirmation message
                IWebElement orderConfirmationMessage = driver.FindElement(By.ClassName("order-number"));
                string confirmationMessage = orderConfirmationMessage.Text;

                Console.WriteLine("Order Confirmation: " + confirmationMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

    }
    }
