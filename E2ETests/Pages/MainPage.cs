using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;

namespace E2ETests.Pages
{
    public class MainPage : BasePage
    {
        private ToolBar topToolbar => WebDriver.FindElement<ToolBar>(By.ClassName("nav-line-wrapper--top"));

        private ToolBar bottomToolBar => WebDriver.FindElement<ToolBar>(By.ClassName("nav-line-wrapper--bottom"));


    }
}
