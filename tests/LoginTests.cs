using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;

namespace App.E2E.Tests
{
    public class LoginTests : IDisposable
    {
        private IWebDriver _driver;

        public LoginTests()
        {
            _driver = new ChromeDriver();
        }

        //[Fact]
        //public void LoginButton_ShouldNavigateToDashboard_WhenCredentialsAreValid()
        //{
            //// Arrange
            //_driver.Navigate().GoToUrl("https://yourapp.com/login"); //ElGen Url

            //var usernameField = _driver.FindElement(By.Id("username"));
            //var passwordField = _driver.FindElement(By.Id("password"));
            //var loginButton = _driver.FindElement(By.Id("loginButton"));

            //// Act
            //usernameField.SendKeys("validUsername");
            //passwordField.SendKeys("validPassword");
            //loginButton.Click();

            //// Assert
            //Assert.Contains("dashboard", _driver.Url, StringComparison.OrdinalIgnoreCase);
        //}

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
