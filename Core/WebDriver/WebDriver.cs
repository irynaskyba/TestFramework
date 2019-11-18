using Core.Search;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using WebElements.Controls;
using WebElements.WebElements;

namespace Core.WebDriver
{
    public class WebDriver
    {
        private static readonly SearchService search = new SearchService();
                
        private static IWebDriver driver;

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

        public static void GoTo(string url)
        {
            driver.Url = url;
        }

        public static T FindElement<T>(By by) where T : UiElement
        {
            return search.FindElement<T>(driver, by);
        }

        public static List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(driver, by);
        }
    }
}
