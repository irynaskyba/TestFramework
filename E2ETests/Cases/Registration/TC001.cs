using E2ETests.Pages;
using NUnit.Framework;

namespace E2ETests.Cases.Registration
{
    public class TC001
    {
        private readonly MainPage _mainPage;

        public TC001()
        {
            _mainPage = new MainPage();
        }

        public void Preconditions()
        {
            _mainPage.BonusPopup.Close.Click();
            _mainPage.Register.Click();
        }

        // 1. Click 'Register'
        public void Step1()
        {
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail не указан" error message appears
            string expectedMessage = "не указан E-mail";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }

        // 2. Enter 'qwe123' into 'Email' field and click 'Зарегестрироваться'
        public void Step2()
        {
            _mainPage.RegistrationDialog.Email.SetText("qwe123");
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail введен неправильно" error message appears 
            string expectedMessage = "E-mail не указан";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }

        // 3. Enter 'qwe123@qwe' into 'Email' field and click 'Зарегестрироваться'
        public void Step3()
        {
            _mainPage.RegistrationDialog.Email.SetText("qwe123@qwe");
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail введен неправильно" error message appears 
            string expectedMessage = "E-mail не указан";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }

        // 4. Enter 'qwe)123@qwe' into 'Email' field and click 'Зарегестрироваться'
        public void Step4()
        {
            _mainPage.RegistrationDialog.Email.SetText("qwe)123@qwe");
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail введен неправильно" error message appears 
            string expectedMessage = "E-mail не указан";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }

        // 5. Enter 'qwe@123@qwe' into 'Email' field and click 'Зарегестрироваться'
        public void Step5()
        {
            _mainPage.RegistrationDialog.Email.SetText("qwe@123@qwe");
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail введен неправильно" error message appears 
            string expectedMessage = "E-mail не указан";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }

        // 6. Enter 'qwe123@qwe.' into 'Email' field and click 'Зарегестрироваться'
        public void Step6()
        {
            _mainPage.RegistrationDialog.Email.SetText("qwe123@qwe.");
            _mainPage.RegistrationDialog.Register.Click();

            // Expected result: "E-mail введен неправильно" error message appears 
            string expectedMessage = "E-mail не указан";
            Assert.IsTrue(_mainPage.RegistrationDialog.IsErrorPresent(expectedMessage));
        }
    }
}
