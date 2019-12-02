using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace E2ETests.Pages
{
    public class NbaPage : BasePage
    {
        private Link addTag => WebDriver.FindElement<Link>(By.CssSelector(".svg-icon.user-panel__svg"));

        private Link signIn => WebDriver.FindElement<Link>(By.XPath("//*[@data-action='login']"));

        private Link myLine => WebDriver.FindElement<Link>(By.ClassName("link_color_light-gray"));

        private List<Link> tags => WebDriver.FindElements<Link>(By.ClassName("user-panel__menu-block-item-tag"));

        public void ClickSignIn() => signIn.Click();

        public void ClickAddTag() => addTag.Click();

        public void ClickMyFeed() => myLine.Click();

        public bool IsTagPresent(string tag)
        {
            var tagsTitles = tags.Select(x => x.GetAttribute("title"));
            return tagsTitles.Contains(tag);
        }        
    }
}
