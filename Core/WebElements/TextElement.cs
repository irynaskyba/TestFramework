using OpenQA.Selenium;
using WebElements.WebElements;

namespace Core.WebElements
{
    public class TextElement : UiElement
    {
        private IWebElement _textElement;

        public TextElement(IWebElement webElement) : base(webElement)
		{
            _textElement = webElement;
        }

        public string Text => _textElement.Text;
    }
}
