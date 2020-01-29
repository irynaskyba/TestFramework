using Core.WebDriver;
using Core.WebElements;
using E2ETests.PageElements;
using E2ETests.PageElements.Dialogs;
using E2ETests.PageElements.Popups;
using OpenQA.Selenium;

namespace E2ETests.Pages
{
    public class MainPage : BasePage
    {
        private ToolBar topToolbar => WebDriver.FindElement<ToolBar>(By.ClassName("nav-line-wrapper--top"));

        private ToolBar bottomToolBar => WebDriver.FindElement<ToolBar>(By.ClassName("nav-line-wrapper--bottom"));

        public Button Register => WebDriver.FindElement<Button>(By.XPath("//*[@data-event-name='reg/start']"));
        
        public RegistrationDialog RegistrationDialog => WebDriver.FindElement<RegistrationDialog>(By.ClassName("tabs__panel_active"));

        public BonusPopup BonusPopup => WebDriver.FindElement<BonusPopup>(By.ClassName("bets-bonus-menu__hover-block"));
    }
}
