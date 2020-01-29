using OpenQA.Selenium;

namespace Core.WebElements
{
    public class Span : UiElement
    {
        private readonly IWebElement _span;

        public Span(IWebElement webElement) : base(webElement)
		{
            _span = webElement;
        }

        public string Text => _span.Text;
    }
}
