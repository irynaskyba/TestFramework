using Core.Search;
using Core.WebDriver;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebElements.WebElements
{
    public class UiElement
    {
        protected readonly WebDriver Driver;

        private SearchService search = new SearchService();

        private readonly IWebElement _webElement;

        public UiElement(IWebElement webElement)
        {
            Driver = WebDriver.Instance;
            _webElement = webElement;
        }

        public T FindElement<T>(By by) where T : UiElement
        {
            return search.FindElement<T>(_webElement, by);
        }

        public List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(_webElement, by);
        }
    }
}
