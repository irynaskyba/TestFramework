using OpenQA.Selenium;

namespace Core.WebElements
{
    public class Link : UiElement
    {
        private readonly IWebElement _link;

        public string Text => _link.Text;

        public Link(IWebElement webElement) : base(webElement)
        {
            _link = webElement;
        }

        public void Click() => _link.Click();
    }
}
