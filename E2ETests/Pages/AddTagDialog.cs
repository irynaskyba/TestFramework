using Core.Wait;
using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;

namespace E2ETests.Pages
{
    public class AddTagDialog : BasePage
    {
        private By dialogLocator => By.ClassName("popup__overlay--usertags");

        private By searchResultLocator(string searchText) => By.XPath($".//li[@class='search-block__results-item']//span[text()='{searchText}']");

        private Div addTagDialog => WebDriver.FindElement<Div>(dialogLocator);

        private InputTextField searchField => addTagDialog.FindElement<InputTextField>(By.XPath(".//*[@class='search-block__input']"));

        private ListItem searchResult(string searchText) => addTagDialog.FindElement<ListItem>(searchResultLocator(searchText));

        private ListItem tag(string name) => addTagDialog.FindElement<ListItem>(By.XPath($".//*[@data-name='{name}']"));

        private Button removeTag(string name) => tag(name).FindElement<Button>(By.ClassName("user-tags__remove-btn"));
        
        public void ClickRemove(string tagName) => removeTag(tagName).Click();
        
        public void SelectTag(string searchText)
        {
            searchField.SetText(searchText);
            Wait.ForElementToExist(searchResultLocator(searchText));
            searchResult(searchText).Click();
        }

        public void Close()
        {
            WebDriver.Refresh();
            Wait.WaitForElementToBeHidden(dialogLocator);
        }
    }
}
