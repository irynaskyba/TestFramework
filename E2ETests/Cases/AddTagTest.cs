using E2ETests.Pages;
using E2ETests.Suites;
using NUnit.Framework;
using System.Threading;

namespace E2ETests.Tests
{
    public class AddTagTest : NbaSuite
    {
        private readonly NbaPage _nbaPage;

        public AddTagTest()
        {
            _nbaPage = new NbaPage();
        }

        public void AddTag(string tagName)
        {
            _nbaPage.ClickAddTag();
            _nbaPage.AddTagDialog.SelectTag(tagName);
            _nbaPage.AddTagDialog.Close();
        }
        
        public void DeleteTag(string tagName)
        {
            _nbaPage.ClickAddTag();
            _nbaPage.AddTagDialog.ClickRemove(tagName);
            _nbaPage.AddTagDialog.Close();
        }

        [Test]
        public void VerifyAddingTag()
        {
            try
            {
                string tagName = "высшая лига Бельгия";

                var test = new AddTagTest();
                test.AddTag(tagName);
                Assert.IsTrue(_nbaPage.IsTagPresent(tagName));
                test.DeleteTag(tagName);
            }
            finally
            {

            }
        }
    }
}
