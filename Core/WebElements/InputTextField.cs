using OpenQA.Selenium;

namespace WebElements.Controls
{
    public class InputTextField : UiElement
    {
        private readonly IWebElement _textField;

        public InputTextField(IWebElement webElement) : base(webElement)
		{
            _textField = webElement;
        }

        public string Text => _textField.Text;
        
        public string Value => _textField.GetAttribute("value");
        
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
