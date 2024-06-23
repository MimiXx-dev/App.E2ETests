using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;
using FluentAssertions;

namespace App.E2E.Tests
{
    public class LoginTests : IDisposable
    {
        private IWebDriver _driver;

        public LoginTests()
        {
            _driver = new ChromeDriver();
        }

        [Fact]
        public void LoginButton_ShouldNavigateToDashboard_WhenCredentialsAreValid()
        {
            // Arrange
            _driver.Navigate().GoToUrl("https://yourapp.com/login"); //ElGen Url

            var usernameField = _driver.FindElement(By.Id("username"));
            var passwordField = _driver.FindElement(By.Id("password"));
            var loginButton = _driver.FindElement(By.Id("loginButton"));

            // Act
            usernameField.SendKeys("validUsername");
            passwordField.SendKeys("validPassword");
            loginButton.Click();

            // Assert
            _driver.Url.Should().Be("https://yourapp.com/dashboard");
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
