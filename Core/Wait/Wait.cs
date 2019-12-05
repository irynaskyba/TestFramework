using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Core.Wait
{
    public class Wait
    {
        public static void ForPageReadyState(int secondsToWait = 15)
        {
            var wait = new WebDriverWait(WebDriver.WebDriver.Instance, TimeSpan.FromSeconds(secondsToWait));
            wait.Until(
                driver => ((IJavaScriptExecutor)WebDriver.WebDriver.Instance)
                          .ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void ForElementToExist(By by, int secondsToWait = 15)
        {
            var wait = new WebDriverWait(WebDriver.WebDriver.Instance, TimeSpan.FromSeconds(secondsToWait));
            wait.Until(ExpectedConditions.ElementExists(by));
        }

        public static void WaitForElementToBeHidden(By by, int secondsToWait = 15)
        {
            var wait = new WebDriverWait(WebDriver.WebDriver.Instance, TimeSpan.FromSeconds(secondsToWait));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }
    }
}
