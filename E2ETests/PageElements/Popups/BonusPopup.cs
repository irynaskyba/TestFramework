using Core.WebElements;
using OpenQA.Selenium;
using Core.Extensions;
using Core.WebDriver;

namespace E2ETests.PageElements.Popups
{
    public class BonusPopup : UiElement
    {
        private readonly UiElement _bonusPopup;

        public BonusPopup(IWebElement webElement) : base(webElement)
        {
            _bonusPopup = webElement.To<UiElement>();
        }

        public Button Close => WebDriver.FindElement<Button>(By.ClassName("bets-bonus-menu__close"));
    }
}
