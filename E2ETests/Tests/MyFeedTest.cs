using E2ETests.Pages;
using E2ETests.Suites;
using NUnit.Framework;
using System.Collections.Generic;

namespace E2ETests.Tests
{
    [TestFixture]
    public class MyFeedTest : NbaSuite
    {
        NbaPage mainPage;
        SignInPage signInPage;
        MyFeedPage myFeedPage;

        [SetUp]
        public void SetUp()
        {
            mainPage = new NbaPage();
            signInPage = new SignInPage();
            myFeedPage = new MyFeedPage();
        }

        [Test]
        [Ignore("TODO")]
        public void VerifyAuthorizedUserCanSeeMyFeed()
        {
            mainPage.ClickSignIn();
            signInPage.SignIn("tribunatest@gmail.com", "e84f181be9");
            mainPage.ClickMyFeed();
            Assert.IsTrue(myFeedPage.IsFeedDisplayed(), "My Feed is not displayed");
        }

        [Test]
        [Ignore("TODO")]
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
