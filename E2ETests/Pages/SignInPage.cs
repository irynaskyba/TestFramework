using Core.WebDriver;
using Core.WebElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using WebElements.Controls;

namespace E2ETests.Pages
{
    public class SignInPage : BasePage
    {
        private Div signInPopup => WebDriver.FindElement<Div>(By.CssSelector(".popup__overlay.js-active"));
        private Div authContainer => WebDriver.FindElement<Div>(By.CssSelector(".auth__login.auth_state_error"));
        private InputTextField username => authContainer.FindElement<InputTextField>(By.XPath(".//input[@name='login']"));
        private InputTextField password => authContainer.FindElement<InputTextField>(By.XPath(".//input[@name='password']"));
        private Button signIn => authContainer.FindElement<Button>(By.XPath(".//*[@type='submit']"));

        public void SignIn(string username, string password)
        {
            this.username.SetText(username);
            this.password.SetText(password);
            signIn.Click();
        }
    }
}
