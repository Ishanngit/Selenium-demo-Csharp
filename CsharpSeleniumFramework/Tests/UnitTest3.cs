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
using SeleniumExtras.WaitHelpers;

namespace CsharpSeleniumFramework.Tests
{
    internal class UnitTest3 : BaseClass
    {
        [Test]
        public void FillAndSubmitForm()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            IWebElement firstNameInput = driver.FindElement(By.Id("firstName"));
            IWebElement lastNameInput = driver.FindElement(By.Id("lastName"));
            IWebElement emailInput = driver.FindElement(By.Id("userEmail"));
            IWebElement genderRadioButton = driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement mobileNumberInput = driver.FindElement(By.Id("userNumber"));
            IWebElement dateOfBirthInput = driver.FindElement(By.Id("dateOfBirthInput"));
            IWebElement subjectsInput = driver.FindElement(By.Id("subjectsInput"));
            IWebElement hobbiesCheckbox = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            IWebElement uploadPictureInput = driver.FindElement(By.Id("uploadPicture"));
            IWebElement currentAddressInput = driver.FindElement(By.Id("currentAddress"));
            IWebElement stateInput = driver.FindElement(By.Id("react-select-3-input"));
            IWebElement cityInput = driver.FindElement(By.Id("react-select-4-input"));
            IWebElement submitButton = driver.FindElement(By.Id("submit"));

            firstNameInput.SendKeys("John");
            lastNameInput.SendKeys("Doe");
            emailInput.SendKeys("johndoe@example.com");
            genderRadioButton.Click();
            mobileNumberInput.SendKeys("1234567890");

            // Select the date of birth
            dateOfBirthInput.Click();
            IWebElement calendar = driver.FindElement(By.ClassName("react-datepicker__month-select"));
            SelectElement selectMonth = new SelectElement(calendar);
            selectMonth.SelectByText("February");
            IWebElement day = driver.FindElement(By.XPath("//div[contains(@class, 'react-datepicker__day--0') and not(contains(@class, 'react-datepicker__day--outside-month'))]"));
            day.Click();

            subjectsInput.SendKeys("Maths");
            subjectsInput.SendKeys(Keys.Enter);

            // Scroll to a specific element
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.Id("//label[@for='hobbies-checkbox-1']"));  
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);


            hobbiesCheckbox.Click();

            uploadPictureInput.SendKeys("path/to/your/picture.jpg");

            currentAddressInput.SendKeys("123 Main St");

            stateInput.SendKeys("NCR");
            stateInput.SendKeys(Keys.Enter);

            cityInput.SendKeys("Delhi");
            cityInput.SendKeys(Keys.Enter);

            submitButton.Click();

            // Wait for the success message
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement successMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("example-modal-sizes-title-lg")));

            // Assert that the success message is displayed
            Assert.IsTrue(successMessage.Displayed);
        }




    }

}

