using Core.Search;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using Core.WebElements;
using Core.Waits;

namespace Core.WebDriver
{
    public class WebDriver
    {
        private static readonly SearchService Search = new SearchService();
        
        private static IWebDriver _driver;
                
        public static IWebDriver Instance
        {
            get
            {
                if (_driver == null)
                {
                    throw new NullReferenceException("Driver is not started. Please call method 'Start'");
                }

                return _driver;
            }

            set { _driver = value; }
        }

        public static void Close() => Instance.Close();
        public static void Quit() => Instance.Quit();

        public static void Refresh() => Instance.Navigate().Refresh();

        public static void Navigate(string url)
        {
            Instance.Url = url;
        }

        public static void MaximizeWindow() => Instance.Manage().Window.Maximize();

        public static T FindElement<T>(By by) where T : UiElement
        {
            Wait.ForPageReadyState();
            Wait.ForElementToExist(by);
            return Search.FindElement<T>(Instance, by);
        }

        public static List<TElement> FindElements<TElement>(By by) where TElement : UiElement
        {
            Wait.ForPageReadyState();
            Wait.ForElementToExist(by);
            return Search.FindElements<TElement>(Instance, by);
        }

        public static void Start()
        {
            Instance = new ChromeDriver();
        }

        public static string GetUrl() => Instance.Url;
    }
}
