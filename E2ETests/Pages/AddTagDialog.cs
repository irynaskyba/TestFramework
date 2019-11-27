﻿using Core.Wait;
using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using WebElements.Controls;

namespace E2ETests.Pages
{
    public class AddTagDialog : BasePage
    {
        private By searchResultLocator(string searchText) => By.XPath($".//li[@class='search-block__results-item']//span[text()='{searchText}']");

        private Div addTagDialog => WebDriver.FindElement<Div>(By.ClassName("user-tags__search"));
        private InputTextField searchField => addTagDialog.FindElement<InputTextField>(By.XPath(".//*[@class='search-block__input']"));
        private ListItem searchResult(string searchText) => addTagDialog.FindElement<ListItem>(searchResultLocator(searchText));
        private Button removeTag => WebDriver.FindElement<Button>(By.ClassName("user-tags__remove-btn"));

        public void SelectTag(string searchText)
        {
            searchField.SetText(searchText);
            Wait.ForElementToExist(searchResultLocator(searchText));
            searchResult(searchText).Click();
        }
        
        public void Close()
        {
            WebDriver.Refresh();
        }

        public void ClickRemove()
        {
            removeTag.Click();
        }
    }
}
