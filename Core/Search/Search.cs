using OpenQA.Selenium;
using System.Collections.Generic;
using WebElements.Controls;
using WebElements.WebElements;

namespace Core.Search
{
    public sealed class SearchService
    {
		public T FindElement<T>(ISearchContext searchContext, By by) where T : UiElement
        {
            var element = searchContext.FindElement(by);
            var result = element as T;
            return result;
        }
        
        public List<T> FindElements<T>(ISearchContext searchContext, By by) where T : UiElement
        {
            var elements = searchContext.FindElements(by);
            var resolvedElements = new List<T>();

            foreach (var currentElement in elements)
            {
                var result = currentElement as T;
                resolvedElements.Add(result);
            }

            return resolvedElements;
        }
    }
}
