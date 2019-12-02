using Core.Extensions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using Core.WebElements;

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
            return elements.Select(currentElement => currentElement.To<T>()).ToList();
        }
    }
}
