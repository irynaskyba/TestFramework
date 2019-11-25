using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WebElements.Controls;

namespace E2ETests.Pages
{
    public class AddTagDialog : BasePage
    {
        private Div addTagDialog => WebDriver.FindElement<Div>(By.ClassName("user-tags__search"));
        private InputTextField searchField => addTagDialog.FindElement<InputTextField>(By.XPath(".//*[@class='search-block__input']"));
        private List<ListItem> searchResults => addTagDialog.FindElements<ListItem>(By.XPath(".//li[@class='search-block__results-item']"));

        public void SelectTag(string tagName) => SelectTag(tagName, tagName);

        public void SelectTag(string tagName, string searchText)
        {
            searchField.SetText(searchText);
            searchResults.Where(x => x.Text == tagName).FirstOrDefault().Click();
        }
        
        public void Close()
        {
            WebDriver.driver.Navigate().Refresh();
        }
    }
}
