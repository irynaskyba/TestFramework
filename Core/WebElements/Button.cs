using OpenQA.Selenium;

namespace Core.WebElements
{
    public class Button : UiElement
    {
        private readonly IWebElement _button;

        public Button(IWebElement webElement) : base(webElement)
        {
            _button = webElement;
        }

        public void Click() => _button.Click();
    }
}
