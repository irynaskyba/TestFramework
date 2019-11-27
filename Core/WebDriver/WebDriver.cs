using Core.Search;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using WebElements.WebElements;

namespace Core.WebDriver
{
    public class WebDriver
    {
        private static readonly SearchService search = new SearchService();
        
        private static IWebDriver driver;
                
        public static IWebDriver Instance
        {
            get
            {
                if (driver == null)
                {
                    throw new Exception("Driver is not started. Please call method 'Start'");
                }

                return driver;
            }

            set { driver = value; }
        }

        public static void Close() => driver.Close();
        public static void Quit() => driver.Quit();

        public static void Refresh() => driver.Navigate().Refresh();

        public static void Navigate(string url)
        {
            driver.Url = url;
        }

        public static void MaximizeWindow() => driver.Manage().Window.Maximize();

        public static T FindElement<T>(By by) where T : UiElement
        {
            return search.FindElement<T>(driver, by);
        }

        public static List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            return search.FindElements<TElement>(driver, by);
        }

        public static void Start()
        {
            Instance = new ChromeDriver();
        }
    }
}
