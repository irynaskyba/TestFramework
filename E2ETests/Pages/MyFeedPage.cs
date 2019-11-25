using OpenQA.Selenium;

namespace E2ETests.Pages
{
    public class MyFeedPage : BasePage
    {
        private By feedContainerLocator => By.ClassName("user-feed");

        public bool IsFeedDisplayed()
        {
            return IsElementPresent(feedContainerLocator);
        }
    }
}
