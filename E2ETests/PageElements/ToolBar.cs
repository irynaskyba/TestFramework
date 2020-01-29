using Core.Extensions;
using Core.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace E2ETests.PageElements
{
    public class ToolBar : UiElement
    {
        private readonly UiElement _toolBar;

        public ToolBar(IWebElement webElement) : base(webElement)
        {
            _toolBar = webElement.To<UiElement>();
        }

        private List<Link> options => _toolBar.FindElements<Link>(By.XPath(".//li[@class='nav-list__item']"));

        private Link option(string optionName) => _toolBar.FindElement<Link>(By.XPath($".//li[text()='{optionName}']"));

        public void ClickOption(string optionName) => option(optionName).Click();

        public List<string> GetOptions() => options.Select(x => x.Text).ToList();
    }
}
