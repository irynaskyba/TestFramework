using Core.Search;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebElements.WebElements
{
    public class UiElement
    {

        private SearchService search = new SearchService();

        private IWebElement _webElement;

        public UiElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public bool Displayed => _webElement.Displayed;

        public T FindElement<T>(By by, int secondsToWait = 5) where T : UiElement
        {
            return search.FindElement<T>(_webElement, by);
        }

        public List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(_webElement, by);
        }

        public string GetAttribute(string attributeName) => _webElement.GetAttribute(attributeName);
    }
}
