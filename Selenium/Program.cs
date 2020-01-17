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

        public async event WhenScreenChanges(object run, EventArgs e);

        public void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver();
            var chromeWebElement = new ChromeWebElement(chromeDriver, "test");



            INavigation navigation = _webDriver.Navigate();
            navigation.Back();



        }

        public async string WhenScreenChanges(object run, EventArgs)
        {

        }
    }
}

