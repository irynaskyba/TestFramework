using Core.WebElements;
using OpenQA.Selenium;
using Core.Extensions;
using Core.Waits;
using System;

namespace E2ETests.PageElements.Dialogs
{
    public class RegistrationDialog : UiElement
    {
        private readonly UiElement _registrationDialog;

        public RegistrationDialog(IWebElement webElement) : base (webElement)
		{
            _registrationDialog = webElement.To<UiElement>();
        }

        private readonly By _errorMessageLocator = By.CssSelector(".auth__message-error");

        public InputTextField Email => _registrationDialog.FindElement<InputTextField>(By.XPath(".//input[@name='login']"));

        public InputTextField Password => _registrationDialog.FindElement<InputTextField>(By.XPath(".//input[@name='password']"));

        public InputTextField Nickname => _registrationDialog.FindElement<InputTextField>(By.XPath(".//input[@name='nick']"));

        public InputTextField ConfirmPassword => _registrationDialog.FindElement<InputTextField>(By.XPath(".//input[@name='repasswd']"));

        public Button Register => _registrationDialog.FindElement<Button>(By.XPath(".//*[@data-event-name='reg/success']"));

        public Span ErrorMessage => _registrationDialog.FindElement<Span>(_errorMessageLocator);

        public bool IsErrorPresent(string error)
        {
            try
            {
                Wait.WaitForTextToBePresentByLocator(_errorMessageLocator, error, 5);
                return true;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }
    }
}
