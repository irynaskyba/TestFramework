using OpenQA.Selenium;

namespace Core.WebElements
{
    public class InputTextField : UiElement
    {
        private readonly IWebElement _textField;

        public InputTextField(IWebElement webElement) : base(webElement)
		{
            _textField = webElement;
        }
        
        public void SetText(string text, bool append = false)
        {
            if (!append)
            {
                _textField.Clear();
            }
            _textField.SendKeys(text);
        }
    }
}
