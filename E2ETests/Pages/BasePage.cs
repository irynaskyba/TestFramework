using Core.Wait;
using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace E2ETests.Pages
{
    public class BasePage
    {
        protected bool IsElementPresent(By by)
        {
            var elements = WebDriver.FindElements<UiElement>(by);
            return elements.Count != 0;
        }

        protected string GetRelativeUri()
        {
            Wait.ForPageReadyState();
            var absoluteUrl = new Uri(WebDriver.GetUrl());
            var baseUrl = new Uri(ConfigurationManager.AppSettings["baseUrl"]);

            var relativeUri = baseUrl.MakeRelativeUri(absoluteUrl);
            return relativeUri.ToString();
        }
    }
}
