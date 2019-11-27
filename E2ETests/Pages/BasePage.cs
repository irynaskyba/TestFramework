﻿using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebElements.WebElements;

namespace E2ETests.Pages
{
    public class BasePage
    {
        private List<TextElement> catHeaderFear => WebDriver.FindElements<TextElement>(By.ClassName("cat-header--fear"));

        protected bool IsElementPresent(By by)
        {
            var elements = WebDriver.FindElements<UiElement>(by);
            return elements.Count != 0;
        }
        
        public bool HasCatErrors() => catHeaderFear.Count != 0;

        public List<string> GetCatErrorMessages()
        {
            var errors = catHeaderFear.Select(x => x.Text);
            return errors.ToList();
        }
    }
}
