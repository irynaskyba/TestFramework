using Core.Search;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using WebElements.WebElements;

namespace Core.WebDriver
{
    public class WebDriver
    {
        private static readonly SearchService search = new SearchService();
                        
        public static IWebDriver driver;

        private static WebDriver _instance;

        public WebDriver()
        {
            driver = new ChromeDriver();
        }
        
        public static WebDriver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WebDriver();
                    driver.Manage().Window.Maximize();
                    GoTo("https://ua.tribuna.com/nba/?gr=www");
                }

                return _instance;
            }
        }

        public static void Close() => driver.Close();
        public static void Quit() => driver.Quit();

        public static void GoTo(string url)
        {
            driver.Url = url;
        }

        public T FindElement<T>(By by) where T : UiElement
        {
            return search.FindElement<T>(driver, by);
        }

        public List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(driver, by);
        }
    }
}
