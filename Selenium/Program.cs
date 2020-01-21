using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class Program
    {
        private static IWebDriver _webDriver = new ChromeDriver();
        private IWebElement _webElement;

        public static void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver();
            var chromeWebElement = new ChromeWebElement(chromeDriver, "test");
            WebDriverWait wait = new WebDriverWait(_webDriver, new TimeSpan(500));

            var submitButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("SubmitButton")));
            var input = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("NameInput")));
            var nameBar = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("NameBar")));

            INavigation navigation = _webDriver.Navigate();
            navigation.GoToUrl("https://digital-christmas-card.ballatoilet.repl.co/");
            
            input.SendKeys("Test");
            submitButton.Click();
            string test = "Test";
            if (nameBar.Displayed.Equals(test))
                Console.WriteLine("success");
            else
                Console.WriteLine($"Fail, the nameBar contains: {nameBar.Displayed}");
        }
    }
}

