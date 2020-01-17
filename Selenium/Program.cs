using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class Program
    {
        private IWebDriver _webDriver = new ChromeDriver();
        private IWebElement _webElement;

        public void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver();
            var chromeWebElement = new ChromeWebElement(chromeDriver, "test");

            

            INavigation navigation = _webDriver.Navigate();
            navigation.Back();

            Environment
            

            var exception = new WebDriverException("there is something wrong");
            string js = string.Format("window.scroll(0, {0});", link.Location.Y);
            _webDriver.Quit();
        }
    }
}
