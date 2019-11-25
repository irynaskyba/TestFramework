using OpenQA.Selenium;
using WebElements.WebElements;

namespace Core.WebElements
{
    public class Link : UiElement
    {
        private readonly IWebElement _link;

        public Link(IWebElement webelement) : base(webelement)
        {
            _link = webelement;
        }

        public void Click()
        {
            _link.Click();
        } 
    }
}
