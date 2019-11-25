using Core.Extensions;
using OpenQA.Selenium;
using System.Collections.Generic;
using WebElements.WebElements;

namespace Core.Search
{
    public sealed class SearchService
    {
		public T FindElement<T>(ISearchContext searchContext, By by) where T : UiElement
        {
            var element = searchContext.FindElement(by);
            var result = element.To<T>();
            return result;
        }
        
        public List<T> FindElements<T>(ISearchContext searchContext, By by) where T : UiElement
        {
            var elements = searchContext.FindElements(by);
            var resolvedElements = new List<T>();
            foreach (var currentElement in elements)
            {
                var result = currentElement.To<T>();
                resolvedElements.Add(result);
            }

            return resolvedElements;
        }
    }
}
