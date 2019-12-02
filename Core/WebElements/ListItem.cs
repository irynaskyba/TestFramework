using OpenQA.Selenium;

namespace Core.WebElements
{
    public class ListItem : UiElement
    {
        private readonly IWebElement _listItem;

        public ListItem(IWebElement webElement) : base(webElement)
		{
            _listItem = webElement;
        }
        
        public void Click() => _listItem.Click();
    }
}
