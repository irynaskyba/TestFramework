using System.Collections.Generic;
using Core.Search;
using OpenQA.Selenium;
using Core.Waits;

namespace Core.WebElements
{
    public class UiElement
    {

        private readonly SearchService _search = new SearchService();

        private readonly IWebElement _webElement;

        public UiElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        internal IWebElement WebElement => _webElement;

        public string GetAttribute(string attributeName) => _webElement.GetAttribute(attributeName);

        public bool Displayed => _webElement.Displayed;

        public T FindElement<T>(By by, int secondsToWait = 5) where T : UiElement
        {
            Wait.ForPageReadyState();
            Wait.ForElementToExist(by);
            return _search.FindElement<T>(_webElement, by);
        }

        public List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            Wait.ForPageReadyState();
            Wait.ForElementToExist(by);
            return _search.FindElements<TElement>(_webElement, by);
        }
    }
}
