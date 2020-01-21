using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class Program
    {
        private static IWebDriver _webDriver = new ChromeDriver();
        private static IWebElement _webElement;
        private static ChromeDriver ChromeDriver { get; set; } = new ChromeDriver();
        private static WebDriverWait Wait { get; set; } = new WebDriverWait(ChromeDriver, new TimeSpan(50));
        private ChromeWebElement ChromeWebElement {get; set;} = new ChromeWebElement(ChromeDriver, "test");
        public void Main(string[] args)
        {
            INavigation navigation = _webDriver.Navigate();
            navigation.GoToUrl("https://digital-christmas-card.ballatoilet.repl.co/");
            var submitButton = ChromeDriver.FindElementById("SubmitButton");
        }
    }
}

