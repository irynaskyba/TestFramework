using OpenQA.Selenium;
using WebElements.WebElements;

namespace Core.WebElements
{
    public class ListItem : UiElement
    {
        private IWebElement _listItem;

        public ListItem(IWebElement webElement) : base(webElement)
		{
            _listItem = webElement;
        }
        
        public string Text => _listItem.Text;

        public void Click() => _listItem.Click();
    }
}
