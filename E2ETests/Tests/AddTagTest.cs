using E2ETests.Pages;
using E2ETests.Suites;
using NUnit.Framework;
using System.Threading;

namespace E2ETests.Tests
{
    public class AddTagTest : NbaSuite
    {
        private readonly NbaPage _nbaPage;
        private readonly AddTagDialog _addTagDialog;

        public AddTagTest()
        {
            _nbaPage = new NbaPage();
            _addTagDialog = new AddTagDialog();
        }

        public void AddTag(string tagName)
        {
            _nbaPage.ClickAddTag();
            _addTagDialog.SelectTag(tagName);
            _addTagDialog.Close();
        }
        
        public void DeleteTag(string tagName)
        {
            _nbaPage.ClickAddTag();
            _addTagDialog.ClickRemove(tagName);
            _addTagDialog.Close();
        }

        [Test]
        public void VerifyAddingTag()
        {
            string tagName = "высшая лига Бельгия";

            var test = new AddTagTest();
            test.AddTag(tagName);
            Assert.IsTrue(_nbaPage.IsTagPresent(tagName));
            test.DeleteTag(tagName);
        }
    }
}
