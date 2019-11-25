using OpenQA.Selenium;
using WebElements.WebElements;

namespace Core.WebElements
{
    public class Button : UiElement
    {
        private readonly IWebElement _button;

        public Button(IWebElement webelement) : base(webelement)
        {
            _button = webelement;
        }

        public void Click()
        {
            _button.Click();
        }
    }
}
