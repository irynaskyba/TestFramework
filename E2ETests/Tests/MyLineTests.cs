using E2ETests.Pages;
using NUnit.Framework;
using System.Collections.Generic;

namespace E2ETests.Tests
{
    [TestFixture]
    public class MyLineTests
    {
        MainPage mainPage;
        SignInPage signInPage;
        MyFeedPage myFeedPage;

        [SetUp]
        public void SetUp()
        {
            mainPage = new MainPage();
            signInPage = new SignInPage();
            myFeedPage = new MyFeedPage();
        }

        [TearDown]
        public void TearDown()
        {
            myFeedPage.CloseBrowser();
        }

        [Test]
        public void VerifyAuthorizedUserCanSeeMyFeed()
        {
            mainPage.ClickSignIn();
            signInPage.SignIn("tribunatest@gmail.com", "e84f181be9");
            mainPage.ClickMyFeed();
            Assert.IsTrue(myFeedPage.IsFeedDisplayed(), "My Feed is not displayed");
        }

        [Test]
        public void VerifyUnauthorizedUserCannotSeeMyFeed()
        {
            mainPage.ClickMyFeed();
            
            Assert.IsTrue(signInPage.HasCatErrors(), "Error is not displayed");
            var expectedMessages = new List<string>()
                    { "Вы не авторизованы.\r\nВойдите или зарегистрируйтесь, чтобы читать ленту — весь контент по интересующим вас темам" }; 
            CollectionAssert.AreEqual(expectedMessages, signInPage.GetCatErrorMessages());
            Assert.IsFalse(myFeedPage.IsFeedDisplayed(), "My Feed is displayed when it was not expected");
        }
    }
}
