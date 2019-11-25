using Core.Search;
using Core.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace WebElements.WebElements
{
    public class UiElement
    {
        protected readonly WebDriver Driver;

        private SearchService search = new SearchService();

        private IWebElement _webElement;

        public UiElement(IWebElement webElement)
        {
            Driver = WebDriver.Instance;
            _webElement = webElement;
        }

        public bool Displayed => _webElement.Displayed;

        public T FindElement<T>(By by, int secondsToWait = 5) where T : UiElement
        {
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(secondsToWait));
            wait.Until(ExpectedConditions.ElementExists(by));
            return search.FindElement<T>(_webElement, by);
        }

        public List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(_webElement, by);
        }

        public string GetAttribute(string attributeName) => _webElement.GetAttribute(attributeName);
    }
}
