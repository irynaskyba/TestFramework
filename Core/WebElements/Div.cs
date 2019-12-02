using OpenQA.Selenium;

namespace Core.WebElements
{
    public class Div : UiElement
    {
        private readonly IWebElement _div;

        public Div(IWebElement webElement) : base(webElement)
		{
            _div = webElement;
        }
    }
}
