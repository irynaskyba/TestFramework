using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using Core.Waits;
using E2ETests.PageElements.Dialogs;

namespace E2ETests.Pages
{
    public class NbaPage : BasePage
    {
        private static readonly By _addTagLocator = By.CssSelector(".svg-icon.user-panel__svg");

        private Link addTag => WebDriver.FindElement<Link>(_addTagLocator);

        private Link signIn => WebDriver.FindElement<Link>(By.XPath("//*[@data-action='login']"));

        private Link myLine => WebDriver.FindElement<Link>(By.ClassName("link_color_light-gray"));

        private List<Link> tags => WebDriver.FindElements<Link>(By.ClassName("user-panel__menu-block-item-tag"));

        public AddTagDialog AddTagDialog => WebDriver.FindElement<AddTagDialog>(By.XPath("TODO"));


        public void ClickAddTag()
        {
            Wait.ForElementToExist(_addTagLocator);
            addTag.Click();
        }

        public bool IsTagPresent(string tag)
        {
            var tagsTitles = tags.Select(x => x.GetAttribute("title"));
            return tagsTitles.Contains(tag);
        }
    }
}
