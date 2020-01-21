using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class Program
    {
        private static IWebDriver _webDriver = new ChromeDriver();
        private static ChromeDriver ChromeDriver { get; set; } = new ChromeDriver();
        private static IWebElement _webElement;
        private static WebDriverWait Wait { get; set; } = new WebDriverWait(_webDriver, new TimeSpan(50));
        public static void Main(string[] args)
        {
            INavigation navigation = _webDriver.Navigate();
            navigation.GoToUrl("https://digital-christmas-card.ballatoilet.repl.co/");
            var submitButton = new ChromeWebElement(ChromeDriver, "SubmitButton");
            var resetButton = new ChromeWebElement(ChromeDriver, "ResetButton");
            var input = new ChromeWebElement(ChromeDriver, "NameInput");
            var nameBar = new ChromeWebElement(ChromeDriver, "NameBar");
            input.SendKeys("Test");
            submitButton.Click();
            var test = "Test";
            test.Equals(nameBar.Text);
        }
    }
}

